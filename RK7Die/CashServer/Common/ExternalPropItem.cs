namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("externalPropItem", Namespace = "")]
    public partial class ExternalPropItem
    {

        /// <summary>
        /// <para xml:lang="ru">Имя свойства</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _value = "";

        /// <summary>
        /// <para xml:lang="ru">Значение свойства</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("value", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }

}
