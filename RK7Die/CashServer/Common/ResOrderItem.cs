namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("resOrderItem", Namespace = "")]
    public partial class ResOrderItem
    {

        /// <summary>
        /// <para xml:lang="ru">Работник, создавший
        ///                        заказ</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Creator", Namespace = "")]
        public ResEmployeeItem Creator { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Главный официант заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Waiter", Namespace = "")]
        public ResOrderItemWaiter Waiter { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Станция, на которой был создан заказ</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Station", Namespace = "")]
        public ResRefItem Station { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Категория заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OrderCategory", Namespace = "")]
        public ResRefItem OrderCategory { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Тип заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OrderType", Namespace = "")]
        public ResRefItem OrderType { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Стол</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Table", Namespace = "")]
        public ResRefItem Table { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Тип гостей</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("GuestType", Namespace = "")]
        public ResRefItem GuestType { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Ресторан доставки</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Restaurant", Namespace = "")]
        public ResRefItem Restaurant { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Список гостей</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Guests", Namespace = "")]
        public Guests_Item Guests { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ExternalPropItem> _externalProps;

        /// <summary>
        /// <para xml:lang="ru">Список внешних свойств заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute("ExternalProps", Namespace = "")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Prop", Namespace = "")]
        public System.Collections.ObjectModel.Collection<ExternalPropItem> ExternalProps
        {
            get
            {
                return this._externalProps;
            }
            private set
            {
                this._externalProps = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ExternalProps-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ExternalProps collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExternalPropsSpecified
        {
            get
            {
                return (this.ExternalProps.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ResOrderItem" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ResOrderItem" /> class.</para>
        /// </summary>
        public ResOrderItem()
        {
            this._externalProps = new System.Collections.ObjectModel.Collection<ExternalPropItem>();
            this._session = new System.Collections.ObjectModel.Collection<ResSessionItem>();
        }

        [System.Xml.Serialization.XmlElementAttribute("DeliveryBlock", Namespace = "")]
        public DeliveryBlock DeliveryBlock { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ResSessionItem> _session;

        /// <summary>
        /// <para xml:lang="ru">Список пакетов заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Session", Namespace = "")]
        public System.Collections.ObjectModel.Collection<ResSessionItem> Session
        {
            get
            {
                return this._session;
            }
            private set
            {
                this._session = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Session-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Session collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SessionSpecified
        {
            get
            {
                return (this.Session.Count != 0);
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("visit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Visit { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute("orderIdent", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderIdent { get; set; }

        /// <summary>
        /// <para xml:lang="ru">URL заказа для code.ucs.ru</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("url", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Url { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Сохраняемый комментарий заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("persistentComment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PersistentComment { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Несохраняемый комментарий заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("nonPersistentComment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NonPersistentComment { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время создания заказа (для банкетных столов время начала банкета)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("openTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime OpenTime { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Длительность заказа (банкета)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("duration", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime Duration { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Duration-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Duration property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DurationSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Владелец банкета (для банкетных заказов)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("holder", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Holder { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Промо-код заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("promoCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PromoCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Имя заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("orderName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderName { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Последовательный номер заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("seqNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int SeqNumber { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SeqNumber-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SeqNumber property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeqNumberSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Версия заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("version", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Version { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Контрольная сумма по содержимому
        ///                    заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("crc32", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Crc32 { get; set; }

        /// <summary>
        /// <para xml:lang="ru">GUID заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("guid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Guid { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - заказ заблокирован для редактирования</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("locked", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Locked { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Locked-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Locked property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LockedSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - все блюда заказа удалены</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("deleted", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Deleted { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Deleted-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Deleted property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeletedSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Сумма заказа (в копейках)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("orderSum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderSum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _prepaySum = "0";

        /// <summary>
        /// <para xml:lang="ru">Сумма незакрытых предоплат (в копейках)</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute("0")]
        [System.Xml.Serialization.XmlAttributeAttribute("prepaySum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PrepaySum
        {
            get
            {
                return this._prepaySum;
            }
            set
            {
                this._prepaySum = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _promisedSum = "0";

        /// <summary>
        /// <para xml:lang="ru">Сумма обещанных платежей (в копейках)</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute("0")]
        [System.Xml.Serialization.XmlAttributeAttribute("promisedSum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PromisedSum
        {
            get
            {
                return this._promisedSum;
            }
            set
            {
                this._promisedSum = value;
            }
        }

        /// <summary>
        /// <para xml:lang="ru">Сумма скидок (в копейках)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("discountSum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int DiscountSum { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Неоплаченная сумма заказа (в
        ///                    копейках)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("unpaidSum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int UnpaidSum { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Количество порций в заказе (в тысячных
        ///                    долях)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("totalPieces", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TotalPieces { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время приготовления (минуты)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("cookMins", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CookMins { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _paid = false;

        /// <summary>
        /// <para xml:lang="ru">Флаг - заказ оплачен</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("paid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Paid
        {
            get
            {
                return this._paid;
            }
            set
            {
                this._paid = value;
            }
        }

        /// <summary>
        /// <para xml:lang="ru">Флаг - заказ завершен</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("finished", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Finished { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Finished-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Finished property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FinishedSpecified { get; set; }
    }

}
