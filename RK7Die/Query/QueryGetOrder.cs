using System;
using System.Collections.Generic;
using System.Text;

namespace RK7Die.Query
{
    /// <summary>
    /// <para xml:lang="ru">Получение содержимого заказа</para>
    /// </summary>
    public partial class QueryGetOrder : RK7Cmd
    {
        /// <summary>
        /// <para xml:lang="ru">Заказ</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Order", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RK7Die.Common.OrderElement Order { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _cMD = "GetOrder";

        [System.ComponentModel.DefaultValueAttribute("GetOrder")]
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
    }
}
