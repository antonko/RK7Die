using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RK7Die.CashServer
{
    public class ClientOptions
    {
        public ClientOptions()
        {

        }

        [Required]
        public string Host { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string Path { get; set; } = "/rk7api/v0/xmlinterface.xml";

        public ClientProtocol ClientProtocol { get; set; } = ClientProtocol.http;

        public int Codepage { get; set; } = 1251;
    }
}
