using System;
using System.Collections.Generic;
using System.Text;

namespace RK7Die.CashServer.Query
{
    public partial class QueryGetOrderList2 : RK7Cmd
    {
        /// <summary>
        /// <para xml:lang="ru">Официант. Если задан, то возвращаются заказы, которые официант может обслуживать</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Waiter", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RK7Die.CashServer.Common.RefItem Waiter { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Стол. Если задан, то
        ///                                        возвращаются заказы для этого стола</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Table", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RK7Die.CashServer.Common.RefItem Table { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _cMD = "GetOrderList2";

        [System.Xml.Serialization.XmlAttributeAttribute("CMD", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public new string CMD
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
        /// <para xml:lang="ru">Флаг - вернуть только активные заказы</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("onlyOpened", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool OnlyOpenedValue { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OnlyOpened-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OnlyOpened property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool OnlyOpenedValueSpecified { get; set; }

        /// <summary>
        /// <para xml:lang="ru">Флаг - вернуть только активные
        ///                                    заказы</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> OnlyOpened
        {
            get
            {
                if (this.OnlyOpenedValueSpecified)
                {
                    return this.OnlyOpenedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnlyOpenedValue = value.GetValueOrDefault();
                this.OnlyOpenedValueSpecified = value.HasValue;
            }
        }
    }
}
