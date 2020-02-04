using System;
using System.Collections.Generic;
using System.Text;

namespace RK7Die.CashServer.Query
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("RK7Query", Namespace = "", AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("RK7Query", Namespace = "")]
    public partial class RK7Query
    {
        [System.Xml.Serialization.XmlElementAttribute("RK7CMD", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RK7Cmd RK7Cmd { get; set; }
    }
}
