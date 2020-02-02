namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("SessionItem", Namespace = "")]
    public partial class SessionItem : SessionAncestor
    {

        /// <summary>
        /// <para xml:lang="ru">Станция, на которой пакет был
        ///                                добавлен</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Station", Namespace = "")]
        public RefItem Station { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Работник, последний редактировавший
        ///                                заказ</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Author", Namespace = "")]
        public RefItem Author { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Работник, создавший
        ///                                пакет</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Creator", Namespace = "")]
        public RefItem Creator { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Порядок подачи</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Course", Namespace = "")]
        public RefItem Course { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DishItem> _dish;

        /// <summary>
        /// <para xml:lang="ru">Блюдо</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Dish", Namespace = "")]
        public System.Collections.ObjectModel.Collection<DishItem> Dish
        {
            get
            {
                return this._dish;
            }
            private set
            {
                this._dish = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Dish-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Dish collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DishSpecified
        {
            get
            {
                return (this.Dish.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="SessionItem" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="SessionItem" /> class.</para>
        /// </summary>
        public SessionItem()
        {
            this._dish = new System.Collections.ObjectModel.Collection<DishItem>();
            this._combo = new System.Collections.ObjectModel.Collection<ComboItem>();
            this._discount = new System.Collections.ObjectModel.Collection<DiscountItem>();
            this._prepay = new System.Collections.ObjectModel.Collection<PrepayItem>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ComboItem> _combo;

        /// <summary>
        /// <para xml:lang="ru">Комбо блюдо</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Combo", Namespace = "")]
        public System.Collections.ObjectModel.Collection<ComboItem> Combo
        {
            get
            {
                return this._combo;
            }
            private set
            {
                this._combo = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Combo-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Combo collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ComboSpecified
        {
            get
            {
                return (this.Combo.Count != 0);
            }
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
        private System.Collections.ObjectModel.Collection<PrepayItem> _prepay;

        /// <summary>
        /// <para xml:lang="ru">Предоплата</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Prepay", Namespace = "")]
        public System.Collections.ObjectModel.Collection<PrepayItem> Prepay
        {
            get
            {
                return this._prepay;
            }
            private set
            {
                this._prepay = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Prepay-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Prepay collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrepaySpecified
        {
            get
            {
                return (this.Prepay.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="ru">Флаг "Зафиксировать цены"</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("fixedPrice", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool FixedPrice { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FixedPrice-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FixedPrice property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FixedPriceSpecified { get; set; }
    }

}
