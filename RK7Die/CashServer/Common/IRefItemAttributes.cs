namespace RK7Die.CashServer.Common
{
    /// <summary>
    /// <para xml:lang="ru">Элемент справочника. Идентифицируется или id, или кодом, или guid.
    ///                Обязательно заполнение одного из полей</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    public partial interface IRefItemAttributes
    {

        string Id
        {
            get;
            set;
        }

        string Code
        {
            get;
            set;
        }

        string Guid
        {
            get;
            set;
        }
    }

}
