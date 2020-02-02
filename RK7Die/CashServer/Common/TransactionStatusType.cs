namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("TransactionStatusType", Namespace = "")]
    public enum TransactionStatusType
    {

        /// <summary>
        /// <para xml:lang="ru">Не выполнена</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <summary>
        /// <para xml:lang="ru">В процессе авторизации (для двухстадийной авторизации)</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <summary>
        /// <para xml:lang="ru">Успешна</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <summary>
        /// <para xml:lang="ru">Подтверждена</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <summary>
        /// <para xml:lang="ru">Аннулирована</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
    }

}
