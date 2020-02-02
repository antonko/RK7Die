namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("dishItem", Namespace = "")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComboItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResComboItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResDishItem))]
    public partial class DishItem : DishAncestor
    {

        /// <summary>
        /// <para xml:lang="ru">Количество блюда (в тысячных долях), для
        ///                            добавляемых блюд. Если кол-во меньше нуля, то это блюдо выкупа, иначе обычная продажа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("quantity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Quantity { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Количество блюда, без учета отказов (в
        ///                            тысячных долях, с 7.4.16.2)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("srcQuantity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int SrcQuantity { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SrcQuantity-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SrcQuantity property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SrcQuantitySpecified { get; set; }

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
    }

}
