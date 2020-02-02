namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("comboComponent", Namespace = "")]
    public partial class ComboComponent : DishAncestor
    {

        /// <summary>
        /// <para xml:lang="ru">Комбо-модификатор, соответствующий
        ///                                комбо-компоненту. По умолчанию возьмется первый
        ///                                подходящий</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ComboModi", Namespace = "")]
        public RefItem ComboModi { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _count = "1";

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

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _isDefault = true;

        /// <summary>
        /// <para xml:lang="ru">Флаг - компонент по
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
