using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DLL
{
    public class DoublyNode<T>
    {
        // haal de data op
        public T Data { get; set; }

        // haal de volgende link en vorige link op
        public DoublyNode<T> Volgende { get; set; }
        public DoublyNode<T> Vorige { get; set; }

        /// <summary>
        /// constructor die de node value geeft
        /// </summary>
        /// <param name="data"></param>
        public DoublyNode(T data)
        {
            // wijs data toe
            this.Data = data;

            // zet de links weer op null
            Volgende = null;
            Vorige = null;
        }
    }
}
