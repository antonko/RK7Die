using System;
using System.Collections.Generic;
using System.Text;

namespace RK7Die.CashServer.Query
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("RK7CMD", Namespace = "", AnonymousType = true)]
    [System.Xml.Serialization.XmlInclude(typeof(GetOrderList))]
    public abstract class RK7Cmd
    {
        private string cMDField;

        public RK7Cmd()
        {
            this.cMDField = "SystemInfo";
        }

        [System.Xml.Serialization.XmlAttributeAttribute("CMD", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CMD
        {
            get
            {
                return this.cMDField;
            }
            set
            {
                this.cMDField = value;
            }
        }
    }
}
