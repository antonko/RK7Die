namespace RK7Die.CashServer.Common
{
    /// <summary>
    /// <para xml:lang="ru">КДС статус блюда (с версии 7.5.5.036)</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("KDSStateType", Namespace = "")]
    public enum KDSStateType
    {

        [System.Xml.Serialization.XmlEnumAttribute("")]
        Empty,

        /// <summary>
        /// <para xml:lang="ru">Блюдо отправлено на КДС</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("sent")]
        Sent,

        /// <summary>
        /// <para xml:lang="ru">Начата готовка блюда</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("started")]
        Started,

        /// <summary>
        /// <para xml:lang="ru">Блюдо приготовлено</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ready")]
        Ready,

        /// <summary>
        /// <para xml:lang="ru">Блюдо забрано с кухни</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("taken")]
        Taken,

        /// <summary>
        /// <para xml:lang="ru">Начата сборка</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("collect")]
        Collect,

        /// <summary>
        /// <para xml:lang="ru">Собрана</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("collected")]
        Collected,

        /// <summary>
        /// <para xml:lang="ru">Парковка заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("startpark")]
        Startpark,

        /// <summary>
        /// <para xml:lang="ru">Окончание парковки заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("endpark")]
        Endpark,
    }

}
