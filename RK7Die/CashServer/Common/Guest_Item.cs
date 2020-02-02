namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("guest_item", Namespace = "")]
    public partial class Guest_Item
    {

        /// <summary>
        /// <para xml:lang="ru">Интерфейс к карте гостя</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Interface", Namespace = "")]
        public RefItem Interface { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Текстовая метка гостя</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("guestLabel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GuestLabel { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Код карты гостя</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("cardCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CardCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ID адреса гостя</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("clientID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long ClientID { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ClientID-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ClientID property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClientIDSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ID адреса гостя</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("addressID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public long AddressID { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AddressID-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AddressID property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddressIDSpecified { get; set; }
    }

}
