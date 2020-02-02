namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("refItem", Namespace = "")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CheckItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComboComponent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComboItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConsumItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscountItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DishAncestor))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DishItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModiItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PayItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrepayItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResComboItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResDishItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VoidItem))]
    public partial class RefItem : IRefItemAttributes
    {

        [System.Xml.Serialization.XmlAttributeAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Id { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute("code", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Code { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute("guid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Guid { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlAttribute> _anyAttribute;

        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlAttribute> AnyAttribute
        {
            get
            {
                return this._anyAttribute;
            }
            private set
            {
                this._anyAttribute = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="RefItem" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="RefItem" /> class.</para>
        /// </summary>
        public RefItem()
        {
            this._anyAttribute = new System.Collections.ObjectModel.Collection<System.Xml.XmlAttribute>();
        }
    }

}
