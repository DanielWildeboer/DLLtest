using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DLL
{
    class Node<T>
    {
        private T value { get; set; }
        public Node<T> next { get; set; }

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
