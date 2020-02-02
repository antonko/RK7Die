namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("RK7QueryResult", Namespace = "")]
    public partial class RK7QueryResult
    {

        /// <summary>
        /// <para xml:lang="ru">Версия кассовой программы</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ServerVersion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ServerVersion { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Версия xml протокола</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("XmlVersion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string XmlVersion { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Сетевое имя программы (с 7.5.3.260)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("NetName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NetName { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Исходная xml-команда</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("CMD", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CMD { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Статус выполнения запроса</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Status", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RK7QueryResultStatus Status { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Код ошибки RK7</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("RK7ErrorN", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RK7ErrorN { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Текст ошибки</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ErrorText", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ErrorText { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время обработки запроса (в
        ///                    миллисекундах)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("WorkTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WorkTime { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Дата и время генерации ответного xml
        ///                    (xmlver&gt;=39)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("DateTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime DateTime { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Количество обработанных команд</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Processed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Processed { get; set; }
    }

}
