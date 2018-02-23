using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DLL
{
    public class GenericArrayList<T>
    {
        private T[] array;
        public int length;
        public GenericArrayList(int size)
        {
            array = new T[size + 1];
            length = size;
        }

        public T getItem(int index)
        {
            return array[index];
        }

        public void setItem(int index, T value)
        {
            array[index] = value;
            
        }
        public void setArray(int index, ref T value)
        {
            
            array[index] = value;
        }

        public int getSize()
        {
            return length;
        }
    }
}

