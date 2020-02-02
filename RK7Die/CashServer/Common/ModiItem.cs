namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("modiItem", Namespace = "")]
    public partial class ModiItem : CheckItem
    {

        /// <summary>
        /// <para xml:lang="ru">Цена модификатора (в
        ///                            копейках)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("price", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Price { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Price-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Price property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _count = "1";

        /// <summary>
        /// <para xml:lang="ru">Количество модификаторов</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute("1")]
        [System.Xml.Serialization.XmlAttributeAttribute("count", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Count
        {
            get
            {
                return this._count;
            }
            set
            {
                this._count = value;
            }
        }

        /// <summary>
        /// <para xml:lang="ru">Произвольное имя
        ///                            модификатора</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("openName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OpenName { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isDefault = true;

        /// <summary>
        /// <para xml:lang="ru">Флаг - модификатор по
        ///                            умолчанию</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("isDefault", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsDefault
        {
            get
            {
                return this._isDefault;
            }
            set
            {
                this._isDefault = value;
            }
        }
    }

}
