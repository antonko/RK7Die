namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("resRefItem", Namespace = "")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResEmployeeItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResOrderItemWaiter))]
    public partial class ResRefItem
    {

        [System.Xml.Serialization.XmlAttributeAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Id { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute("code", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Code { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute("name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name { get; set; }
    }

}
