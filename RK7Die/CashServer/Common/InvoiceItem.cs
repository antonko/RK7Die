namespace RK7Die.CashServer.Common
{
    /// <summary>
    /// <para xml:lang="ru">Счет/фактура</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("invoiceItem", Namespace = "")]
    public partial class InvoiceItem
    {

        /// <summary>
        /// <para xml:lang="ru">GUID счет/фактуры</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("guid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Guid { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ИНН</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("regno", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Regno { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Наименование</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Адрес</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("address", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Address { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Доп.инфо</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("extrainfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Extrainfo { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Комментарий</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("comment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Comment { get; set; }
    }
}
