namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("prepayItem", Namespace = "")]
    public partial class PrepayItem : PayItem
    {

        /// <summary>
        /// <para xml:lang="ru">Причина внесения
        ///                                предоплаты</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Reason", Namespace = "")]
        public RefItem Reason { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Предоплата является обещанным платежом</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("promised", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Promised { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Promised-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Promised property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromisedSpecified { get; set; }
    }

}
