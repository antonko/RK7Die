namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("resSessionItem", Namespace = "")]
    public partial class ResSessionItem : SessionAncestor
    {

        /// <summary>
        /// <para xml:lang="ru">Станция, на которой пакет был
        ///                                добавлен</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Station", Namespace = "")]
        public ResRefItem Station { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Работник, последний редактировавший
        ///                                заказ</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Author", Namespace = "")]
        public ResEmployeeItem Author { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Работник, создавший
        ///                                пакет</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Creator", Namespace = "")]
        public ResEmployeeItem Creator { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Порядок подачи</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Course", Namespace = "")]
        public ResRefItem Course { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResDishItem> _dish;

        /// <summary>
        /// <para xml:lang="ru">Блюдо</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Dish", Namespace = "")]
        public System.Collections.ObjectModel.Collection<ResDishItem> Dish
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ResSessionItem" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ResSessionItem" /> class.</para>
        /// </summary>
        public ResSessionItem()
        {
            this._dish = new System.Collections.ObjectModel.Collection<ResDishItem>();
            this._combo = new System.Collections.ObjectModel.Collection<ResComboItem>();
            this._discount = new System.Collections.ObjectModel.Collection<DiscountItem>();
            this._prepay = new System.Collections.ObjectModel.Collection<PrepayItem>();
            this._pay = new System.Collections.ObjectModel.Collection<PayItem>();
            this._printCheck = new System.Collections.ObjectModel.Collection<PrintCheckItem>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResComboItem> _combo;

        /// <summary>
        /// <para xml:lang="ru">Комбо блюдо</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Combo", Namespace = "")]
        public System.Collections.ObjectModel.Collection<ResComboItem> Combo
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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<PayItem> _pay;

        /// <summary>
        /// <para xml:lang="ru">Оплата</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Pay", Namespace = "")]
        public System.Collections.ObjectModel.Collection<PayItem> Pay
        {
            get
            {
                return this._pay;
            }
            private set
            {
                this._pay = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Pay-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Pay collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaySpecified
        {
            get
            {
                return (this.Pay.Count != 0);
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<PrintCheckItem> _printCheck;

        /// <summary>
        /// <para xml:lang="ru">Чек</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PrintCheck", Namespace = "")]
        public System.Collections.ObjectModel.Collection<PrintCheckItem> PrintCheck
        {
            get
            {
                return this._printCheck;
            }
            private set
            {
                this._printCheck = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PrintCheck-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PrintCheck collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintCheckSpecified
        {
            get
            {
                return (this.PrintCheck.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="ru">Тип цены, используемый для содержимого
        ///                                пакета</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PriceScale", Namespace = "")]
        public ResRefItem PriceScale { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Торговая группа</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TradeGroup", Namespace = "")]
        public ResRefItem TradeGroup { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время приготовления
        ///                            (минуты)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("cookMins", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CookMins { get; set; }

        /// <summary>
        /// <para xml:lang="ru">UNI пакета</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sessionID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int SessionID { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SessionID-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SessionID property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SessionIDSpecified { get; set; }
    }

}
