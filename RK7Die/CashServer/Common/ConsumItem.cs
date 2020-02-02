namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("consumItem", Namespace = "")]
    public partial class ConsumItem : CheckItem
    {

        /// <summary>
        /// <para xml:lang="ru">Работник, который добавил консуманта</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Author", Namespace = "")]
        public RefItem Author { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Сумма консумации (в копейках)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Amount { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Amount-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Amount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified { get; set; }
    }

}
