namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("resDishItem", Namespace = "")]
    public partial class ResDishItem : DishItem
    {

        /// <summary>
        /// <para xml:lang="ru">Сумма блюда (в копейках)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("amount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Amount { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Amount-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Amount property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private KDSStateType _kdsstate = RK7Die.CashServer.Common.KDSStateType.Empty;

        /// <summary>
        /// <para xml:lang="ru">КДС статус блюда (с версии 7.5.5.037)</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(RK7Die.CashServer.Common.KDSStateType.Empty)]
        [System.Xml.Serialization.XmlAttributeAttribute("kdsstate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public KDSStateType Kdsstate
        {
            get
            {
                return this._kdsstate;
            }
            set
            {
                this._kdsstate = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _new = false;

        /// <summary>
        /// <para xml:lang="ru">Флаг - новое блюдо (последний добавленный
        ///                            элемент)</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("new", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool New
        {
            get
            {
                return this._new;
            }
            set
            {
                this._new = value;
            }
        }
    }

}
