namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("dishAncestor", Namespace = "")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComboComponent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComboItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DishItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResComboItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResDishItem))]
    public partial class DishAncestor : CheckItem
    {

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ModiItem> _modi;

        /// <summary>
        /// <para xml:lang="ru">Модификатор</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Modi", Namespace = "")]
        public System.Collections.ObjectModel.Collection<ModiItem> Modi
        {
            get
            {
                return this._modi;
            }
            private set
            {
                this._modi = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Modi-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Modi collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModiSpecified
        {
            get
            {
                return (this.Modi.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="DishAncestor" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DishAncestor" /> class.</para>
        /// </summary>
        public DishAncestor()
        {
            this._modi = new System.Collections.ObjectModel.Collection<ModiItem>();
            this._discount = new System.Collections.ObjectModel.Collection<DiscountItem>();
            this._void = new System.Collections.ObjectModel.Collection<VoidItem>();
            this._consum = new System.Collections.ObjectModel.Collection<ConsumItem>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DiscountItem> _discount;

        /// <summary>
        /// <para xml:lang="ru">Скидка</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Discount", Namespace = "")]
        public System.Collections.ObjectModel.Collection<DiscountItem> Discount
        {
            get
            {
                return this._discount;
            }
            private set
            {
                this._discount = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Discount-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Discount collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscountSpecified
        {
            get
            {
                return (this.Discount.Count != 0);
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<VoidItem> _void;

        /// <summary>
        /// <para xml:lang="ru">Отказы (для распечатанных
        ///                                блюд)</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Void", Namespace = "")]
        public System.Collections.ObjectModel.Collection<VoidItem> Void
        {
            get
            {
                return this._void;
            }
            private set
            {
                this._void = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Void-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Void collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VoidSpecified
        {
            get
            {
                return (this.Void.Count != 0);
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ConsumItem> _consum;

        /// <summary>
        /// <para xml:lang="ru">Консуманты</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Consum", Namespace = "")]
        public System.Collections.ObjectModel.Collection<ConsumItem> Consum
        {
            get
            {
                return this._consum;
            }
            private set
            {
                this._consum = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Consum-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Consum collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConsumSpecified
        {
            get
            {
                return (this.Consum.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="ru">Цена блюда (в копейках)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("price", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Price { get; set; }
    }

}
