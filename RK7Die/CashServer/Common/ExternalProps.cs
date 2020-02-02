namespace RK7Die.CashServer.Common
{
    /// <summary>
    /// <para xml:lang="ru">Список внешних свойств заказа</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("externalProps", Namespace = "")]
    public partial class ExternalProps
    {

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ExternalPropItem> _prop;

        [System.Xml.Serialization.XmlElementAttribute("Prop", Namespace = "")]
        public System.Collections.ObjectModel.Collection<ExternalPropItem> Prop
        {
            get
            {
                return this._prop;
            }
            private set
            {
                this._prop = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Prop-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Prop collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PropSpecified
        {
            get
            {
                return (this.Prop.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ExternalProps" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ExternalProps" /> class.</para>
        /// </summary>
        public ExternalProps()
        {
            this._prop = new System.Collections.ObjectModel.Collection<ExternalPropItem>();
        }
    }

}
