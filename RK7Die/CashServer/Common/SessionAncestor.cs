namespace RK7Die.CashServer.Common
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("sessionAncestor", Namespace = "")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResSessionItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SessionItem))]
    public partial class SessionAncestor
    {

        /// <summary>
        /// <para xml:lang="ru">UNI пакета. Если задан, то перезаписывается
        ///                    содержимое пакета. Иначе создается новый пакет</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("uni", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int Uni { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Uni-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Uni property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UniSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">GUID пакета</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("line_guid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Line_Guid { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг "Пакет является черновиком"</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("isDraft", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool IsDraft { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die IsDraft-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IsDraft property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDraftSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - пакет распечатан</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("printed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool Printed { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Printed-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Printed property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintedSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время, в которое блюда были добавлены в заказ. Если
        ///                    не задано, то используется время remindAt</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("printTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime PrintTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PrintTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrintTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время начала готовки блюд пакета. Если не задано, то
        ///                    используется текущее время</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("remindTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime RemindTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RemindTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RemindTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemindTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время, к которому должны быть приготовлены все блюда
        ///                    пакета</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("readyTime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime ReadyTime { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReadyTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReadyTime property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReadyTimeSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Время начала обслуживания</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("startService", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "dateTime")]
        public System.DateTime StartService { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die StartService-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StartService property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartServiceSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.XmlAttribute> _anyAttribute;

        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Collections.ObjectModel.Collection<System.Xml.XmlAttribute> AnyAttribute
        {
            get
            {
                return this._anyAttribute;
            }
            private set
            {
                this._anyAttribute = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="SessionAncestor" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="SessionAncestor" /> class.</para>
        /// </summary>
        public SessionAncestor()
        {
            this._anyAttribute = new System.Collections.ObjectModel.Collection<System.Xml.XmlAttribute>();
        }
    }

}
