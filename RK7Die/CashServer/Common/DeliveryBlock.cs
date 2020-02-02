namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("deliveryBlock", Namespace = "")]
    public partial class DeliveryBlock
    {

        /// <summary>
        /// <para xml:lang="ru">Статус доставки</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("deliveryState", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int DeliveryState { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DeliveryState-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DeliveryState property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryStateSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время создания заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("startTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die StartTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StartTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время в пути</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("travelTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime TravelTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TravelTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TravelTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TravelTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Ожидаемое время доставки</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("deliveryTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime DeliveryTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DeliveryTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DeliveryTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время отправки экспедитора</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("forwarderSendTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime ForwarderSendTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ForwarderSendTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ForwarderSendTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ForwarderSendTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время возвращения экспедитора</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("forwarderReturnTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime ForwarderReturnTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ForwarderReturnTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ForwarderReturnTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ForwarderReturnTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Реальное время доставки</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("realDeliveryTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime RealDeliveryTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RealDeliveryTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RealDeliveryTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RealDeliveryTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время последней обработки заказа. Заполняет Delivery</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("lastProcessTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime LastProcessTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die LastProcessTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LastProcessTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastProcessTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Минимальное время приготовления заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("minCookTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime MinCookTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MinCookTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MinCookTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinCookTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">ID зоны доставки</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("zoneID", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int ZoneID { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ZoneID-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ZoneID property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZoneIDSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Имя зоны доставки</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("zoneName", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ZoneName { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Префиск для имени заказа</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("orderPrefix", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OrderPrefix { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - доставка на вынос. Если флаг выставлен, то
        ///                    статусами доставки на филиале управляет RK7</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("isTakeOut", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsTakeOut { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die IsTakeOut-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IsTakeOut property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsTakeOutSpecified { get; set; }
    }

}
