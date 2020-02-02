namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("comboItem", Namespace = "")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResComboItem))]
    public partial class ComboItem : DishItem
    {

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ComboComponent> _component;

        /// <summary>
        /// <para xml:lang="ru">Комбо компонент</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Component", Namespace = "")]
        public System.Collections.ObjectModel.Collection<ComboComponent> Component
        {
            get
            {
                return this._component;
            }
            private set
            {
                this._component = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Component-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Component collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ComponentSpecified
        {
            get
            {
                return (this.Component.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ComboItem" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ComboItem" /> class.</para>
        /// </summary>
        public ComboItem()
        {
            this._component = new System.Collections.ObjectModel.Collection<ComboComponent>();
        }
    }

}
