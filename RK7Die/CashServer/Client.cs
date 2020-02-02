using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
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
        private readonly ILogger _logger;
        private readonly HttpClient _httpClient;
        private readonly int _codePage;

        public Client(ClientOptions clientOptions, ILogger logger = null)
        {
            if (clientOptions.ClientProtocol != ClientProtocol.http)
            {
                throw new Exception("Protocol is not supported by this library");
            }

            if (logger == null)
            {
                _logger = NullLogger.Instance;
            }
            else
            {
                _logger = logger;
            }

            _codePage = clientOptions.Codepage;

            _logger.LogWarning("test");

            _httpClient = InitializationHttpClient(clientOptions);


        }

        private HttpClient InitializationHttpClient(ClientOptions clientOptions)
        {
            //Так как на серверах RK7 используется самоподписанный сертификат, приходится игнорировать ошибку проверки сертификата
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback =
                (message, certificate, chain, sslPolicyErrors) => true;

            HttpClient httpClient = new HttpClient(httpClientHandler);

            var hostUri = new Uri(clientOptions.Host);
            var pathUri = new Uri(clientOptions.Path);

            _httpClient.BaseAddress = new Uri(hostUri, pathUri);

            //Basic-авторизация, используется по умолчанию в RK7
            if (!String.IsNullOrEmpty(clientOptions.Username) && !String.IsNullOrEmpty(clientOptions.Password))
            {
                var byteArray = Encoding.ASCII.GetBytes($"{clientOptions.Username}:{clientOptions.Password}");
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
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

        //TODO переписать на Async
        public string SendQuery(RK7Cmd _RK7CMD)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            RK7Query rK7Query = new RK7Query();
            rK7Query.RK7Cmd = _RK7CMD;

            string xmlBody = SerializeQuery(rK7Query);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, _httpClient.BaseAddress)
            {
                Content = new StringContent(xmlBody, Encoding.GetEncoding(_codePage), "text/xml")
            };

            var responce = _httpClient.SendAsync(httpRequest).GetAwaiter().GetResult();
            string result = responce.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            return result;
        }
    }

    public enum ClientProtocol
    {
        http, tcp
    }
}
