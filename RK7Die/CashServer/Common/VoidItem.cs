namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("voidItem", Namespace = "")]
    public partial class VoidItem : CheckItem
    {

        /// <summary>
        /// <para xml:lang="ru">Работник, выполняющий
        ///                                удаление</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Author", Namespace = "")]
        public RefItem Author { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ДатаВремя создания воида</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("dateTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime DateTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DateTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DateTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Количество удаляемого блюда (в тысячных
        ///                            долях)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("quantity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Quantity { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Сумма удаляемого блюда</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Amount { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Amount-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Amount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Открытое имя причины
        ///                            удаления</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("openName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OpenName { get; set; }
    }

}
