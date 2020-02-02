namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("discountItem", Namespace = "")]
    public partial class DiscountItem : CheckItem
    {

        /// <summary>
        /// <para xml:lang="ru">Интерфейс к карте гостя. Обезателен для
        ///                                заполнения, если задан cardCode</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Interface", Namespace = "")]
        public RefItem Interface { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Тип бонуса, заполняется для скидок ПДС</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BonusType", Namespace = "")]
        public RefItem BonusType { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Сумма скидки (в копейках), для скидок с
        ///                            ручным вводом суммы скидки</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Amount { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Amount-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Amount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Максимальная сумма скидки (в копейках)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("maxamount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Maxamount { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Maxamount-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Maxamount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxamountSpecified { get; set; }

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
        /// <para xml:lang="ru">Код карточки</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("cardCode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CardCode { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Признак того что скидка удалена</para>
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
