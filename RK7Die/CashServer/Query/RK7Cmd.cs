namespace RK7Die.CashServer.Query
{
    [System.Xml.Serialization.XmlTypeAttribute("RK7CMD", Namespace = "", AnonymousType = true)]
    [System.Xml.Serialization.XmlInclude(typeof(QueryGetOrderList))]
    [System.Xml.Serialization.XmlInclude(typeof(QueryGetOrderList2))]
    [System.Xml.Serialization.XmlInclude(typeof(QueryGetOrder))]
    public abstract class RK7Cmd
    {
        public RK7Cmd()
        {
            this.CMD = "SystemInfo";
        }

        [System.Xml.Serialization.XmlAttributeAttribute("CMD", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CMD { get; set; }
    }
}
