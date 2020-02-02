namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("payItem", Namespace = "")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrepayItem))]
    public partial class PayItem : CheckItem
    {

        /// <summary>
        /// <para xml:lang="ru">Интерфейс, связанный с
        ///                                оплатой</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Interface", Namespace = "")]
        public RefItem Interface { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Сумма (в копейках)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Amount { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Номер персональной карты</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("cardCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CardCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Внешний код авторизации. Начиная с версии 7.5.3.111</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("extTransactionInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExtTransactionInfo { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Статус авторизации. Начиная с версии 7.5.4.211</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("TransactionStatus", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TransactionStatusType TransactionStatus { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransactionStatus-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TransactionStatus property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionStatusSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _seat = "0";

        /// <summary>
        /// <para xml:lang="ru">Номер посадочного места: 0 - не
        ///                            задано</para>
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
        /// <para xml:lang="ru">Признак того что платеж удален</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("deleted", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Deleted { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Deleted-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Deleted property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeletedSpecified { get; set; }
    }

}
