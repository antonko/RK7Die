using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RK7Die
{
    /// <summary>
    /// Настройки доступа к R-Keeper API
    /// </summary>
    public class ClientOptions
    {
        public ClientOptions()
        {

        }

        /// <summary>
        /// Хост с указанием протокола и порта, например https://192.168.0.1:9000/
        /// </summary>
        [Required]
        public string Host { get; set; }

        /// <summary>
        /// Пусть до интерфейса API
        /// </summary>
        public string Path { get; set; } = "/rk7api/v0/xmlinterface.xml";

        /// <summary>
        /// Логин для basic-авторизации
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Пароль для basic-авторизации
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Протокол доступа, в данной версии может быть только https
        /// </summary>
        public ClientProtocol ClientProtocol { get; set; } = ClientProtocol.http;

        /// <summary>
        /// Кодовая страница с которой работает R-Keeper, по умолчанию 1251
        /// </summary>
        public int Codepage { get; set; } = 1251;
    }

    public enum ClientProtocol
    {
        http, tcp
    }
}
