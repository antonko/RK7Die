using RK7Die.CashServer.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RK7Die.CashServer.Result
{
    /// <summary>
    /// <para xml:lang="ru">xml-ответ GetOrderList</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlRootAttribute("RK7QueryResult", Namespace = "")]
    public partial class GetOrderList : RK7QueryResult
    {

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<VisitItem> _visit;

        [System.Xml.Serialization.XmlElementAttribute("Visit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<VisitItem> Visit
        {
            get
            {
                return this._visit;
            }
            private set
            {
                this._visit = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Visit-Collection leer ist.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisitSpecified
        {
            get
            {
                return (this.Visit.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="GetOrderList" /> Klasse.</para>
        /// </summary>
        public GetOrderList()
        {
            this._visit = new System.Collections.ObjectModel.Collection<VisitItem>();
        }

        /// <summary>
        /// <para xml:lang="ru">Версия таблицы заказов</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("lastversion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lastversion { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("guestItem", Namespace = "")]
    public partial class GuestItem
    {

        /// <summary>
        /// <para xml:lang="ru">Текстовая метка гостя</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("GuestLabel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GuestLabel { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Признак того, что место закрыто</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("closed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Closed { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Closed-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Closed property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClosedSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Код карты гостя</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("CardCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CardCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ID интефейса</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("IntfID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IntfID { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Код интефейса</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("IntfCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IntfCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Наименование интефейса</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("IntfName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IntfName { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("orderItem", Namespace = "")]
    public partial class OrderItem
    {

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<OrderItemExternalID> _externalID;

        /// <summary>
        /// <para xml:lang="ru">Внешний id заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ExternalID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<OrderItemExternalID> ExternalID
        {
            get
            {
                return this._externalID;
            }
            private set
            {
                this._externalID = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ExternalID-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ExternalID collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExternalIDSpecified
        {
            get
            {
                return (this.ExternalID.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="OrderItem" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="OrderItem" /> class.</para>
        /// </summary>
        public OrderItem()
        {
            this._externalID = new System.Collections.ObjectModel.Collection<OrderItemExternalID>();
            this._extraTables = new System.Collections.ObjectModel.Collection<RK7Die.CashServer.Common.RefItem>();
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RK7Die.CashServer.Common.RefItem> _extraTables;

        /// <summary>
        /// <para xml:lang="ru">Список дополнительных столов</para>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute("ExtraTables", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<RK7Die.CashServer.Common.RefItem> ExtraTables
        {
            get
            {
                return this._extraTables;
            }
            private set
            {
                this._extraTables = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ExtraTables-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ExtraTables collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtraTablesSpecified
        {
            get
            {
                return (this.ExtraTables.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="ru">ID заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("OrderID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderID { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Версия заказа (с 7.4.8.0)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Version", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Version { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Контрольная сумма по содержимому заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("crc32", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Crc32 { get; set; }

        /// <summary>
        /// <para xml:lang="ru">GUID заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("guid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Guid { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг "Не проверять лицензию xml-сохранение заказа". Такие заказы не видны на кассе"</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("dontcheckLicense", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool DontcheckLicense { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DontcheckLicense-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DontcheckLicense property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DontcheckLicenseSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Промо-код заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("promoCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PromoCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг "Заказ заблокирован"</para>
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
        /// <para xml:lang="ru">URL заказа для code.ucs.ru</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("url", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Url { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Пользовательское имя заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("OrderName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderName { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Сумма заказа (в копейках)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("OrderSum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderSum { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Неоплаченная сумма (в копейках). Начиная с версии 7.5.3.130 сумма возвращается с учетом предоплат</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ToPaySum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ToPaySum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _prepaySum = "0";

        /// <summary>
        /// <para xml:lang="ru">Сумма незакрытых предоплат (в копейках)</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute("0")]
        [System.Xml.Serialization.XmlAttributeAttribute("PrepaySum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlAttributeAttribute("PromisedSum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        /// <para xml:lang="ru">Сумма заказа по прейскуранту (в копейках)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("PriceListSum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PriceListSum { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Сумма порций всех блюд заказа( в тысячных долях)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("TotalPieces", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TotalPieces { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Дата и время создания заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("CreateTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime CreateTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CreateTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the CreateTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreateTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Дата и время завершения заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("FinishTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime FinishTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FinishTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FinishTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FinishTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">0 - заказ открыт, 1 - обслуживание по заказу завершено</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Finished", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Finished { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Finished-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Finished property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FinishedSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - в заказе есть пречек</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Bill", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Bill { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Bill-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Bill property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BillSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - в заказе есть ошибочный чек</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ReceiptError", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ReceiptError { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReceiptError-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReceiptError property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceiptErrorSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - в заказе есть десерт</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Dessert", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Dessert { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Dessert-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Dessert property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DessertSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - заказ рассчитан по местам</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("bySeats", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool BySeats { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BySeats-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BySeats property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BySeatsSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - в заказе есть готовые, но незабранные блюда</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ReadyExists", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ReadyExists { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReadyExists-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReadyExists property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReadyExistsSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - в заказе есть блюда, для которых требуется указание веса</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("WeightNeeded", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool WeightNeeded { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die WeightNeeded-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the WeightNeeded property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeightNeededSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ДатаВремя печати пречека</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("BillTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime BillTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BillTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BillTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BillTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ДатаВремя добавления в заказ десерта</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("DessertTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime DessertTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DessertTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DessertTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DessertTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ID стола</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("TableID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TableID { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Код стола</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("TableCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TableCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Наименование стола</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("TableName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TableName { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ID официанта</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("WaiterID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WaiterID { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Код официанта</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("WaiterCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WaiterCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Наименование официанта</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("WaiterName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WaiterName { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ID категории заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("OrderCategID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderCategID { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Код категории заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("OrderCategCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderCategCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Наименование категории заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("OrderCategName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderCategName { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ID типа заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("OrderTypeID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderTypeID { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Код типа заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("OrderTypeCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderTypeCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Наименование типа заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("OrderTypeName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderTypeName { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ID типа неплательщика</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("DefaulterID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DefaulterID { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Код типа неплательщика</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("DefaulterCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DefaulterCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Наименование типа неплательщика</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("DefaulterName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DefaulterName { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("OrderItemExternalID", Namespace = "", AnonymousType = true)]
    public partial class OrderItemExternalID
    {

        /// <summary>
        /// <para xml:lang="ru">id-программы, создавшей
        ///                                заказ</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ExtSource", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExtSource { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Дополнительный id
        ///                                заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ExtID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExtID { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("visitItem", Namespace = "")]
    public partial class VisitItem
    {

        /// <summary>
        /// <para xml:lang="ru">Информация о
        ///                        гостях</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Guests", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public VisitItemGuests Guests { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<OrderItem> _orders;

        /// <summary>
        /// <para xml:lang="ru">Информация о
        ///                        гостях</para>
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute("Orders", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Order", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<OrderItem> Orders
        {
            get
            {
                return this._orders;
            }
            private set
            {
                this._orders = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Orders-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Orders collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrdersSpecified
        {
            get
            {
                return (this.Orders.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="VisitItem" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="VisitItem" /> class.</para>
        /// </summary>
        public VisitItem()
        {
            this._orders = new System.Collections.ObjectModel.Collection<OrderItem>();
        }

        /// <summary>
        /// <para xml:lang="ru">Идентификатор
        ///                    визита</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("VisitID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VisitID { get; set; }

        /// <summary>
        /// <para xml:lang="ru">GUID визита</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("guid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Guid { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - визит
        ///                    завершен</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Finished", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Finished { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Finished-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Finished property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FinishedSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Количество
        ///                    гостей</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("GuestsCount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GuestsCount { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Сохраняемый
        ///                    комментарий</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("PersistentComment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PersistentComment { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Несохраняемый
        ///                    комментарий</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("NonPersistentComment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NonPersistentComment { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ID типа
        ///                    гостей</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("GuestTypeID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GuestTypeID { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Код типа
        ///                    гостей</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("GuestTypeCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GuestTypeCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Наименование типа
        ///                    гостей</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("GuestTypeName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GuestTypeName { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("VisitItemGuests", Namespace = "", AnonymousType = true)]
    public partial class VisitItemGuests
    {

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<GuestItem> _guest;

        [System.Xml.Serialization.XmlElementAttribute("Guest", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<GuestItem> Guest
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="VisitItemGuests" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="VisitItemGuests" /> class.</para>
        /// </summary>
        public VisitItemGuests()
        {
            this._guest = new System.Collections.ObjectModel.Collection<GuestItem>();
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
