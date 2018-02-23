using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DLL.Hoofdstuk_11
{
    /// <summary>
    ///  Doubly node voor doubly Linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public class DoublyNode<T>
    {
        // haal de data op
        public T data { get; set; }

        // haal de volgende link en vorige link op
        public DoublyNode<T> volgende { get; set; }
        public DoublyNode<T> vorige { get; set; }

        /// <summary>
        /// constructor die de node value geeft
        /// </summary>
        /// <param name="data"></param>
        public DoublyNode(T data)
        {
            // wijs data toe
            this.data = data;

            // zet de links weer op null
            volgende = null;
            vorige = null;
        }
    }
}
