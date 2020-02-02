namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("checkItem", Namespace = "")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComboComponent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComboItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConsumItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiscountItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DishAncestor))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DishItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModiItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PayItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PrepayItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResComboItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResDishItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VoidItem))]
    public partial class CheckItem : RefItem
    {

        /// <summary>
        /// <para xml:lang="ru">UNI элемента. Если задан, то элемент
        ///                            обновляется, иначе создается новый. Только для нераспечатанных
        ///                            элементов</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("uni", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Uni { get; set; }

        /// <summary>
        /// <para xml:lang="ru">GUID строки</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("line_guid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Line_Guid { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Статус элемента (с версии 7.5.4.206)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("state", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CheckItemState State { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die State-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the State property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StateSpecified { get; set; }
    }

}
