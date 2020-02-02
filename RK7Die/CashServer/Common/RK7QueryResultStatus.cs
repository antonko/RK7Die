namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("RK7QueryResultStatus", Namespace = "")]
    public enum RK7QueryResultStatus
    {

        Ok,

        [System.Xml.Serialization.XmlEnumAttribute("No changes")]
        No_Changes,

        [System.Xml.Serialization.XmlEnumAttribute("Execution Started")]
        Execution_Started,

        [System.Xml.Serialization.XmlEnumAttribute("Query Parse Error")]
        Query_Parse_Error,

        [System.Xml.Serialization.XmlEnumAttribute("Bad Query Parameters")]
        Bad_Query_Parameters,

        [System.Xml.Serialization.XmlEnumAttribute("Query Executing Error")]
        Query_Executing_Error,

        [System.Xml.Serialization.XmlEnumAttribute("Result Writing Error")]
        Result_Writing_Error,
    }

}
