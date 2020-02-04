using System;
using System.Collections.Generic;
using System.Text;

namespace RK7Die.CashServer.Query
{
    [System.Xml.Serialization.XmlTypeAttribute("RK7CMD", Namespace = "", AnonymousType = true)]
    [System.Xml.Serialization.XmlInclude(typeof(RK7Die.CashServer.Query.QueryGetOrderList))]
    [System.Xml.Serialization.XmlInclude(typeof(RK7Die.CashServer.Query.QueryGetOrderList2))]
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
