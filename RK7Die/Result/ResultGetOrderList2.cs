using System;
using System.Collections.Generic;
using System.Text;
using RK7Die.Common;

namespace RK7Die.Result
{
    /// <summary>
    /// <para xml:lang="ru">xml-ответ GetOrderList2</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlRootAttribute("RK7QueryResult", Namespace = "")]
    public partial class ResultGetOrderList2 : RK7QueryResult
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
        /// <para xml:lang="en">Gets a value indicating whether the Visit collection is empty.</para>
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="RK7QueryResult" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="RK7QueryResult" /> class.</para>
        /// </summary>
        public ResultGetOrderList2()
        {
            this._visit = new System.Collections.ObjectModel.Collection<VisitItem>();
        }

        /// <summary>
        /// <para xml:lang="ru">Версия таблицы заказов</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("lastversion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lastversion { get; set; }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
        [System.Xml.Serialization.XmlTypeAttribute("visitItem", Namespace = "")]
        public partial class VisitItem
        {

            /// <summary>
            /// <para xml:lang="ru">Тип гостей</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("GuestType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RK7Die.Common.ResRefItem GuestType { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Список гостей</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Guests", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RK7Die.Common.Guests_Item Guests { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<OrderItem> _orders;

            /// <summary>
            /// <para xml:lang="ru">Список заказов</para>
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
            [System.Xml.Serialization.XmlAttributeAttribute("visit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Visit { get; set; }

            /// <summary>
            /// <para xml:lang="ru">GUID визита</para>
            /// </summary>
            [System.Xml.Serialization.XmlAttributeAttribute("guid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Guid { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Флаг - визит
            ///                    завершен</para>
            /// </summary>
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("finished", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool FinishedValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Finished-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Finished property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool FinishedValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Флаг - визит
            ///                    завершен</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<bool> Finished
            {
                get
                {
                    if (this.FinishedValueSpecified)
                    {
                        return this.FinishedValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.FinishedValue = value.GetValueOrDefault();
                    this.FinishedValueSpecified = value.HasValue;
                }
            }

            /// <summary>
            /// <para xml:lang="ru">Сохраняемый
            ///                    комментарий</para>
            /// </summary>
            [System.Xml.Serialization.XmlAttributeAttribute("persistentComment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string PersistentComment { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Несохраняемый
            ///                    комментарий</para>
            /// </summary>
            [System.Xml.Serialization.XmlAttributeAttribute("nonPersistentComment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string NonPersistentComment { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
        [System.Xml.Serialization.XmlTypeAttribute("orderItem", Namespace = "")]
        public partial class OrderItem
        {

            /// <summary>
            /// <para xml:lang="ru">Работник, создавший заказ</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Creator", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RK7Die.Common.ResRefItem Creator { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Главный официант</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Waiter", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RK7Die.Common.ResRefItem Waiter { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Категория заказа</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("OrderCategory", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RK7Die.Common.ResRefItem OrderCategory { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Тип заказа</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("OrderType", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RK7Die.Common.ResRefItem OrderType { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Стол</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Table", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RK7Die.Common.ResRefItem Table { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Неплательщик</para>
            /// </summary>
            [System.Xml.Serialization.XmlElementAttribute("Defaulter", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public RK7Die.Common.ResRefItem Defaulter { get; set; }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<RK7Die.Common.ExternalPropItem> _externalProps;

            /// <summary>
            /// <para xml:lang="ru">Список внешних свойств заказа</para>
            /// </summary>
            [System.Xml.Serialization.XmlArrayAttribute("ExternalProps", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            [System.Xml.Serialization.XmlArrayItemAttribute("Prop", Namespace = "")]
            public System.Collections.ObjectModel.Collection<RK7Die.Common.ExternalPropItem> ExternalProps
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
            /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="OrderItem" /> Klasse.</para>
            /// <para xml:lang="en">Initializes a new instance of the <see cref="OrderItem" /> class.</para>
            /// </summary>
            public OrderItem()
            {
                this._externalProps = new System.Collections.ObjectModel.Collection<RK7Die.Common.ExternalPropItem>();
                this._extraTables = new System.Collections.ObjectModel.Collection<RK7Die.Common.RefItem>();
            }

            [System.Xml.Serialization.XmlIgnoreAttribute()]
            private System.Collections.ObjectModel.Collection<RK7Die.Common.RefItem> _extraTables;

            /// <summary>
            /// <para xml:lang="ru">Список дополнительных столов</para>
            /// </summary>
            [System.Xml.Serialization.XmlArrayAttribute("ExtraTables", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            [System.Xml.Serialization.XmlArrayItemAttribute("item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public System.Collections.ObjectModel.Collection<RK7Die.Common.RefItem> ExtraTables
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

            [System.Xml.Serialization.XmlAttributeAttribute("visit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Visit { get; set; }

            [System.Xml.Serialization.XmlAttributeAttribute("orderIdent", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string OrderIdent { get; set; }

            /// <summary>
            /// <para xml:lang="ru">GUID заказа</para>
            /// </summary>
            [System.Xml.Serialization.XmlAttributeAttribute("guid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Guid { get; set; }

            /// <summary>
            /// <para xml:lang="ru">URL заказа для code.ucs.ru</para>
            /// </summary>
            [System.Xml.Serialization.XmlAttributeAttribute("url", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public string Url { get; set; }

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
            /// <para xml:lang="ru">Дата и время завершения заказа</para>
            /// </summary>
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("FinishTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
            public System.DateTime FinishTimeValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FinishTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the FinishTime property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool FinishTimeValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Дата и время завершения заказа</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<System.DateTime> FinishTime
            {
                get
                {
                    if (this.FinishTimeValueSpecified)
                    {
                        return this.FinishTimeValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.FinishTimeValue = value.GetValueOrDefault();
                    this.FinishTimeValueSpecified = value.HasValue;
                }
            }

            /// <summary>
            /// <para xml:lang="ru">Длительность заказа (банкета)</para>
            /// </summary>
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("duration", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
            public System.DateTime DurationValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Duration-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Duration property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool DurationValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Длительность заказа (банкета)</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<System.DateTime> Duration
            {
                get
                {
                    if (this.DurationValueSpecified)
                    {
                        return this.DurationValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.DurationValue = value.GetValueOrDefault();
                    this.DurationValueSpecified = value.HasValue;
                }
            }

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
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("seqNumber", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public int SeqNumberValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SeqNumber-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the SeqNumber property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool SeqNumberValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Последовательный номер заказа</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<int> SeqNumber
            {
                get
                {
                    if (this.SeqNumberValueSpecified)
                    {
                        return this.SeqNumberValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.SeqNumberValue = value.GetValueOrDefault();
                    this.SeqNumberValueSpecified = value.HasValue;
                }
            }

            /// <summary>
            /// <para xml:lang="ru">Флаг - заказ заблокирован для редактирования</para>
            /// </summary>
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("locked", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool LockedValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Locked-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Locked property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool LockedValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Флаг - заказ заблокирован для редактирования</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<bool> Locked
            {
                get
                {
                    if (this.LockedValueSpecified)
                    {
                        return this.LockedValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.LockedValue = value.GetValueOrDefault();
                    this.LockedValueSpecified = value.HasValue;
                }
            }

            /// <summary>
            /// <para xml:lang="ru">Флаг - все блюда заказа удалены</para>
            /// </summary>
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("deleted", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool DeletedValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Deleted-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Deleted property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool DeletedValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Флаг - все блюда заказа удалены</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<bool> Deleted
            {
                get
                {
                    if (this.DeletedValueSpecified)
                    {
                        return this.DeletedValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.DeletedValue = value.GetValueOrDefault();
                    this.DeletedValueSpecified = value.HasValue;
                }
            }

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
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("finished", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool FinishedValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Finished-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the Finished property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool FinishedValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Флаг - заказ завершен</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<bool> Finished
            {
                get
                {
                    if (this.FinishedValueSpecified)
                    {
                        return this.FinishedValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.FinishedValue = value.GetValueOrDefault();
                    this.FinishedValueSpecified = value.HasValue;
                }
            }

            /// <summary>
            /// <para xml:lang="ru">Флаг - в заказе есть ошибочный чек</para>
            /// </summary>
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("receiptError", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool ReceiptErrorValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReceiptError-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the ReceiptError property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool ReceiptErrorValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Флаг - в заказе есть ошибочный чек</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<bool> ReceiptError
            {
                get
                {
                    if (this.ReceiptErrorValueSpecified)
                    {
                        return this.ReceiptErrorValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.ReceiptErrorValue = value.GetValueOrDefault();
                    this.ReceiptErrorValueSpecified = value.HasValue;
                }
            }

            /// <summary>
            /// <para xml:lang="ru">Флаг - заказ рассчитан по местам</para>
            /// </summary>
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("bySeats", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool BySeatsValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BySeats-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the BySeats property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool BySeatsValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Флаг - заказ рассчитан по местам</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<bool> BySeats
            {
                get
                {
                    if (this.BySeatsValueSpecified)
                    {
                        return this.BySeatsValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.BySeatsValue = value.GetValueOrDefault();
                    this.BySeatsValueSpecified = value.HasValue;
                }
            }

            /// <summary>
            /// <para xml:lang="ru">Флаг - в заказе есть готовые, но незабранные блюда</para>
            /// </summary>
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("readyExists", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool ReadyExistsValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReadyExists-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the ReadyExists property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool ReadyExistsValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Флаг - в заказе есть готовые, но незабранные блюда</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<bool> ReadyExists
            {
                get
                {
                    if (this.ReadyExistsValueSpecified)
                    {
                        return this.ReadyExistsValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.ReadyExistsValue = value.GetValueOrDefault();
                    this.ReadyExistsValueSpecified = value.HasValue;
                }
            }

            /// <summary>
            /// <para xml:lang="ru">Флаг - в заказе есть блюда, для которых требуется указание веса</para>
            /// </summary>
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("weightNeeded", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public bool WeightNeededValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die WeightNeeded-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the WeightNeeded property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool WeightNeededValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">Флаг - в заказе есть блюда, для которых требуется указание веса</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<bool> WeightNeeded
            {
                get
                {
                    if (this.WeightNeededValueSpecified)
                    {
                        return this.WeightNeededValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.WeightNeededValue = value.GetValueOrDefault();
                    this.WeightNeededValueSpecified = value.HasValue;
                }
            }

            /// <summary>
            /// <para xml:lang="ru">ДатаВремя печати пречека</para>
            /// </summary>
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("billTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
            public System.DateTime BillTimeValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BillTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the BillTime property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool BillTimeValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">ДатаВремя печати пречека</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<System.DateTime> BillTime
            {
                get
                {
                    if (this.BillTimeValueSpecified)
                    {
                        return this.BillTimeValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.BillTimeValue = value.GetValueOrDefault();
                    this.BillTimeValueSpecified = value.HasValue;
                }
            }

            /// <summary>
            /// <para xml:lang="ru">ДатаВремя добавления в заказ десерта</para>
            /// </summary>
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            [System.Xml.Serialization.XmlAttributeAttribute("dessertTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
            public System.DateTime DessertTimeValue { get; set; }

            /// <summary>
            /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DessertTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
            /// <para xml:lang="en">Gets or sets a value indicating whether the DessertTime property is specified.</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
            public bool DessertTimeValueSpecified { get; set; }

            /// <summary>
            /// <para xml:lang="ru">ДатаВремя добавления в заказ десерта</para>
            /// </summary>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public System.Nullable<System.DateTime> DessertTime
            {
                get
                {
                    if (this.DessertTimeValueSpecified)
                    {
                        return this.DessertTimeValue;
                    }
                    else
                    {
                        return null;
                    }
                }
                set
                {
                    this.DessertTimeValue = value.GetValueOrDefault();
                    this.DessertTimeValueSpecified = value.HasValue;
                }
            }
        }

    }
}
