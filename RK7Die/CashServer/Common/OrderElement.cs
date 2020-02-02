namespace RK7Die.CashServer.Common
{
    /// <summary>
    /// <para xml:lang="ru">Ссылка на заказ. Заказ можно выбрать либо по guid либо
    ///                по visit+orderIdent. Если заданы все атрибуты, то сначала поиск выполняется по
    ///                guid</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("orderElement", Namespace = "")]
    public partial class OrderElement
    {

        [System.Xml.Serialization.XmlAttributeAttribute("guid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Guid { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute("visit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Visit { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute("orderIdent", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderIdent { get; set; }
    }

}
