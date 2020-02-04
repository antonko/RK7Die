using System;
using System.Collections.Generic;
using System.Text;
using RK7Die.CashServer.Common;

namespace RK7Die.CashServer.Result
{
    /// <summary>
    /// <para xml:lang="ru">xml-ответ GetOrder</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlRootAttribute("RK7QueryResult", Namespace = "")]
    public partial class ResultGetOrder : RK7QueryResult
    {
        [System.Xml.Serialization.XmlElementAttribute("Order", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RK7Die.CashServer.Common.ResOrderItem Order { get; set; }

    }
}
