namespace RK7Die.CashServer.Common
{
    /// <summary>
    /// <para xml:lang="ru">Список гостей</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("Guests_Item", Namespace = "")]
    public partial class Guests_Item
    {

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<Guest_Item> _guest;

        [System.Xml.Serialization.XmlElementAttribute("Guest", Namespace = "")]
        public System.Collections.ObjectModel.Collection<Guest_Item> Guest
        {
            get
            {
                return this._guest;
            }
            private set
            {
                this._guest = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Guest-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Guest collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GuestSpecified
        {
            get
            {
                return (this.Guest.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Guests_Item" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Guests_Item" /> class.</para>
        /// </summary>
        public Guests_Item()
        {
            this._guest = new System.Collections.ObjectModel.Collection<Guest_Item>();
        }

        /// <summary>
        /// <para xml:lang="ru">Количество гостей</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Count { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Count-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Count property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountSpecified { get; set; }
    }

}
