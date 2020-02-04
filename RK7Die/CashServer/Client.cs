using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using RK7Die.CashServer.Common;
using RK7Die.CashServer.Query;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Xml.Serialization;

namespace RK7Die.CashServer
{
    public class Client
    {
        private readonly ILogger<Client> _logger;
        private readonly HttpClient _httpClient;
        private readonly int _codePage;
        private readonly ClientOptions _clientOptions;

        public Client(IOptionsMonitor<ClientOptions> clientOptions, ILogger<Client> logger = null)
        {
            _clientOptions = clientOptions.CurrentValue;

            if (_clientOptions.ClientProtocol != ClientProtocol.http)
            {
                _logger.LogError("Protocol is not supported by this library");
                throw new Exception("Protocol is not supported by this library");
            }

            if (logger == null)
            {
                _logger = NullLogger<Client>.Instance;
            }
            else
            {
                _logger = logger;
            }

            _codePage = _clientOptions.Codepage;

            _logger.LogWarning("Initialization RK7 CashServer Client");

            _httpClient = InitializationHttpClient(_clientOptions);
        }

        private HttpClient InitializationHttpClient(ClientOptions clientOptions)
        {
            //Так как на серверах RK7 используется самоподписанный сертификат, приходится игнорировать ошибку проверки сертификата
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback =
                (message, certificate, chain, sslPolicyErrors) => true;

            HttpClient httpClient = new HttpClient(httpClientHandler);

            var hostUri = new Uri(clientOptions.Host);

            httpClient.BaseAddress = new Uri(hostUri, clientOptions.Path);

            //Basic-авторизация, используется по умолчанию в RK7
            if (!String.IsNullOrEmpty(clientOptions.Username) && !String.IsNullOrEmpty(clientOptions.Password))
            {
                var byteArray = Encoding.ASCII.GetBytes($"{clientOptions.Username}:{clientOptions.Password}");
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            }

            return httpClient;
        }

        private string SerializeQuery(RK7Query _RK7Query)
        {
            XmlSerializer serializer = new XmlSerializer(_RK7Query.GetType());
            using (var textWriter = new StringWriter())
            {
                serializer.Serialize(textWriter, _RK7Query);
                return textWriter.ToString();
            }
        }

        private RK7QueryResult DeserializeResult(string xmlResult, Type resultType)
        {
            var serializer = new XmlSerializer(resultType);
            RK7QueryResult result;

            using (StringReader reader = new StringReader(xmlResult))
            {
                result = serializer.Deserialize(reader) as RK7QueryResult;
            }

            return result;
        }

        //TODO переписать на Async
        public RK7QueryResult SendQuery(RK7Cmd _RK7Cmd, Type resultType)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            RK7Query rK7Query = new RK7Query { RK7Cmd = _RK7Cmd };

            string xmlBody = SerializeQuery(rK7Query);

            _logger.LogDebug($"Request xmlBody: {xmlBody}");

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, _httpClient.BaseAddress)
            {
                Content = new StringContent(xmlBody, Encoding.GetEncoding(_codePage), "text/xml")
            };

            string resultString;

            try
            {
                var responce = _httpClient.SendAsync(httpRequest).GetAwaiter().GetResult();
                resultString = responce.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw ex;
            }

            _logger.LogDebug($"Result: {resultString}");

            var resultObject = DeserializeResult(resultString, resultType);
            
            return resultObject;
        }
    }

    public enum ClientProtocol
    {
        http, tcp
    }
}
