using RK7Die.CashServer.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace RK7Die.CashServer.Result
{
    /// <summary>
    /// <para xml:lang="ru">xml-ответ GetOrderList</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute("RK7QueryResult", Namespace = "")]
    [System.Xml.Serialization.XmlRootAttribute("RK7QueryResult", Namespace = "")]
    public partial class GetOrderList : RK7QueryResult
    {

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<VisitItem> _visit;

        [System.Xml.Serialization.XmlElementAttribute("Visit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public System.Collections.ObjectModel.Collection<VisitItem> Visit
        {
            get
            {
                return this._visit;
            }
            private set
            {
                this._visit = value;
            }
        }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Visit-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Visit collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VisitSpecified
        {
            get
            {
                return (this.Visit.Count != 0);
            }
        }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="RK7QueryResult2" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="RK7QueryResult2" /> class.</para>
        /// </summary>
        public GetOrderList()
        {
            this._visit = new System.Collections.ObjectModel.Collection<VisitItem>();
        }

        /// <summary>
        /// <para xml:lang="ru">Версия таблицы заказов</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("lastversion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lastversion { get; set; }
    }

}
