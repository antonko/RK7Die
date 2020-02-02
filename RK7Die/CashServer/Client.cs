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
        private HttpClient httpClient;
        private int codePage;

        /// <summary>
        /// </summary>
        /// <param name="_host">Uri-хост, например https://192.168.0.100:9000/</param>
        /// <param name="_userName">Username</param>
        /// <param name="_password">Password</param>
        /// <param name="_path">Путь, опционально. По умолчанию /rk7api/v0/xmlinterface.xml</param>
        /// <param name="_clientProtocol">Прокол связи с сервером. Опционально, в данный момент поддерживается только https.</param>
        /// <param name="_codepage">Кодировка при обмене к RK7</param>
        public Client(Uri _host,
            string _userName,
            string _password,
            string _path = "/rk7api/v0/xmlinterface.xml",
            ClientProtocol _clientProtocol = ClientProtocol.http,
            int _codepage = 1251)
        {
            if (_clientProtocol != ClientProtocol.http)
            {
                throw new Exception("Protocol is not supported by this library");
            }

            codePage = _codepage;

            //Так как на серверах RK7 используется самоподписанный сертификат, приходится игнорировать ошибку проверки сертификата
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback =
                (message, certificate, chain, sslPolicyErrors) => true;

            httpClient = new HttpClient(httpClientHandler);

            httpClient.BaseAddress = new Uri(_host, _path);

            //Base-авторизация, используется по умолчанию
            if (!String.IsNullOrEmpty(_userName) && !String.IsNullOrEmpty(_password))
            {
                var byteArray = Encoding.ASCII.GetBytes($"{_userName}:{_password}");
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            }
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

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, httpClient.BaseAddress)
            {
                Content = new StringContent(xmlBody, Encoding.GetEncoding(codePage), "text/xml")
            };

            var responce = httpClient.SendAsync(httpRequest).GetAwaiter().GetResult();
            string result = responce.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            return result;
        }
    }

    public enum ClientProtocol
    {
        http, tcp
    }
}
