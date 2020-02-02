namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("PrintCheckItem", Namespace = "")]
    public partial class PrintCheckItem
    {

        /// <summary>
        /// <para xml:lang="ru">Кассир, создавший чек</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Author", Namespace = "")]
        public ResEmployeeItem Author { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Причина удаления чека</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Reason", Namespace = "")]
        public RefItem Reason { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Работник, удаливший чек</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DeleteManager", Namespace = "")]
        public ResEmployeeItem DeleteManager { get; set; }

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

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="PrintCheckItem" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="PrintCheckItem" /> class.</para>
        /// </summary>
        public PrintCheckItem()
        {
            this._pay = new System.Collections.ObjectModel.Collection<PayItem>();
            this._prepay = new System.Collections.ObjectModel.Collection<PrepayItem>();
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
        /// <para xml:lang="ru">UNI элемента. Если задан, то элемент обновляется,
        ///                    иначе создается новый. Только для нераспечатанных элементов</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("uni", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Uni { get; set; }

        /// <summary>
        /// <para xml:lang="ru">GUID чека</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("line_guid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Line_Guid { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _seat = "0";

        /// <summary>
        /// <para xml:lang="ru">Номер посадочного места: 0 - не
        ///                    задано</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute("0")]
        [System.Xml.Serialization.XmlAttributeAttribute("seat", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Seat
        {
            get
            {
                return this._seat;
            }
            set
            {
                this._seat = value;
            }
        }

        /// <summary>
        /// <para xml:lang="ru">Номер чека</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("CheckNum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CheckNum { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Номер накладной</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("invoice", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Invoice { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Сумма чека (в копейках)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Amount { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг "Чек удален"</para>
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
        /// <para xml:lang="ru">Флаг "Чек является пречеком"</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("bill", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Bill { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Bill-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Bill property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BillSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время печати чека</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("printTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime PrintTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PrintTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrintTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время начала обслуживания чека</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("startTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die StartTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StartTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartTimeSpecified { get; set; }
    }

}
