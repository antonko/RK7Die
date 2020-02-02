using System;
using System.Collections.Generic;
using System.Text;

namespace RK7Die.CashServer.Query
{
    public partial class GetOrderList : RK7Cmd
    {
        /// <summary>
        /// <para xml:lang="ru">Официант. Если задан, то возвращаются заказы, которые официант может обслуживать</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Waiter", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RK7Die.CashServer.Common.RefItem Waiter { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Стол. Если задан, то возвращаются заказы для этого стола</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Table", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RK7Die.CashServer.Common.RefItem Table { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _cMD = "GetOrderList";

        [System.ComponentModel.DefaultValueAttribute("GetOrderList")]
        [System.Xml.Serialization.XmlAttributeAttribute("CMD", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CMD
        {
            get
            {
                return this._cMD;
            }
            set
            {
                this._cMD = value;
            }
        }

        /// <summary>
        /// <para xml:lang="ru">Кэшировать результат запроса. Если версия таблицы заказов совпадает с lastversion, то возвращается "No changes", иначе обычный ответ</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("lastversion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lastversion { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - вернуть только активные
        ///                                    заказы</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("onlyOpened", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool OnlyOpened { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OnlyOpened-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OnlyOpened property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnlyOpenedSpecified { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _needIdents = true;

        /// <summary>
        /// <para xml:lang="ru">Флаг - возвращать идентификаторы элементов</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("needIdents", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool NeedIdents
        {
            get
            {
                return this._needIdents;
            }
            set
            {
                this._needIdents = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _needCodes = true;

        /// <summary>
        /// <para xml:lang="ru">Флаг - возвращать коды элементов</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("needCodes", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool NeedCodes
        {
            get
            {
                return this._needCodes;
            }
            set
            {
                this._needCodes = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _needNames = false;

        /// <summary>
        /// <para xml:lang="ru">Флаг - возвращать имена элементов</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("needNames", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool NeedNames
        {
            get
            {
                return this._needNames;
            }
            set
            {
                this._needNames = value;
            }
        }
    }
}
