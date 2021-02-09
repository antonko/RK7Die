using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using RK7Die.Common;
using RK7Die.Query;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RK7Die
{
    public class Client
    {
        private readonly HttpClient _httpClient;
        private readonly ClientOptions _clientOptions;
        private ILogger _logger;

        /// <summary>
        /// Конструктор для вызова с помощью dependency injection
        /// </summary>
        /// <param name="clientOptions"></param>
        /// <param name="logger"></param>
        public Client(IOptions<ClientOptions> clientOptions, ILogger<Client> logger = null)
        {
            if (clientOptions == null) throw new ArgumentNullException(nameof(clientOptions));
            _clientOptions = clientOptions.Value ?? throw new ArgumentNullException(nameof(clientOptions));
            _httpClient = Initialization(_clientOptions, logger);
        }

        /// <summary>
        /// Конструктор для вызова вручную из кода
        /// </summary>
        /// <param name="clientOptions"></param>
        /// <param name="logger"></param>
        public Client(ClientOptions clientOptions, ILogger logger = null)
        {
            _clientOptions = clientOptions ?? throw new ArgumentNullException(nameof(clientOptions));
            _httpClient = Initialization(_clientOptions, logger);
        }

        /// <summary>
        /// Инициализация всех необходимых обьектов
        /// </summary>
        /// <param name="clientOptions"></param>
        /// <param name="logger"></param>
        /// <returns></returns>
        private HttpClient Initialization(ClientOptions clientOptions, ILogger logger)
        {
            _logger = logger ?? NullLogger<Client>.Instance;

            if (_clientOptions.ClientProtocol != ClientProtocol.http)
            {
                throw new Exception("Protocol is not supported by this library");
            }

            _logger.LogDebug("Initialization RK7 CashServer Client");
            _logger.LogTrace("ClientOptions: {@clientOptions}", clientOptions);

            //Так как на серверах RK7 используется самоподписанный сертификат, приходится игнорировать ошибку проверки сертификата
            HttpClientHandler httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                (message, certificate, chain, sslPolicyErrors) => true
            };

            HttpClient httpClient = new HttpClient(httpClientHandler);
            httpClient.BaseAddress = new Uri(new Uri(clientOptions.Host), clientOptions.Path);

            //Basic-авторизация, используется по умолчанию в RK7
            if (!String.IsNullOrEmpty(clientOptions.Username) && !String.IsNullOrEmpty(clientOptions.Password))
            {
                var byteArray = Encoding.ASCII.GetBytes($"{clientOptions.Username}:{clientOptions.Password}");
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            }

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            return httpClient;
        }

        private string SerializeQuery(RK7Query RK7Query)
        {
            using (var textWriter = new StringWriter())
            {
                new XmlSerializer(RK7Query.GetType()).Serialize(textWriter, RK7Query);
                _logger.LogTrace("Serialize Query: {textWriter}", textWriter.ToString());
                return textWriter.ToString();
            }
        }

        private RK7QueryResult DeserializeResult(string xmlResult, Type resultType)
        {
            using (StringReader reader = new StringReader(xmlResult))
            {
                return new XmlSerializer(resultType).Deserialize(reader) as RK7QueryResult;
            }
        }

        public async Task<RK7QueryResult> SendQuery(RK7Cmd rK7Cmd, Type resultType)
        {
            if (rK7Cmd == null) throw new ArgumentNullException(nameof(rK7Cmd));

            _logger.LogInformation("Sending request type: {RK7Cmd}", rK7Cmd.GetType());

            string xmlBody = SerializeQuery(new RK7Query { RK7Cmd = rK7Cmd });

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, _httpClient.BaseAddress)
            {
                Content = new StringContent(xmlBody, Encoding.GetEncoding(_clientOptions.Codepage), "text/xml")
            };

            try
            {
                var response = await _httpClient.SendAsync(httpRequest).ConfigureAwait(false);
                var resultString = Encoding.UTF8.GetString(await response.Content.ReadAsByteArrayAsync());

                _logger.LogTrace("R-Keeper server response: {resultString}", resultString);

                var resultObject = DeserializeResult(resultString, resultType);

                _logger.LogTrace("Deserialize Result: {@resultObject}", resultObject);

                return resultObject;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing response R-Keeper");
                throw;
            }
            finally
            {
                httpRequest.Dispose();
            }
        }
    }


}
