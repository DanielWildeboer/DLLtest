using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DLL.Hoofdstuk_10
{
    public class LinearHash<T> : IEnumerable<T>
    {
        private int size;
        private T[] data;
        Boolean done;
        int index;

        public LinearHash(int size)
        {
            this.size = size;
            data = new T[size];
        }

        public void insertItem(T item)
        {
            int position = getPosition(item);
            done = false;
            index = position;

            while (!done) // while not done
            {
                if (Equals(data[index], default(T)))    // check if emty
                {
                    data[index] = item;                 // save the value
                    done = true;                        // done = stop
                }
                else
                {
                    index++;                // next index
                    if (index >= size - 1)  // if out of bounds return to start
                    {
                        index = 0;
                    }
                }
            }
        }

        public void removeItem(T item)
        {
            int position = getPosition(item);

            done = false;
            index = position;

            while (!done) // while not done
            {
                if (data[index].Equals(item))   // if found
                {
                    data[index] = default(T);   // clear element
                    done = true;                // done = stop
                }
                else                        // if not found
                {
                    index++;                // next index
                    if (index >= size - 1)  // if out of bounds return to start
                    {
                        index = 0;
                    }
                }
            }
        }

        protected int getPosition(T item)
        {
            int position = item.GetHashCode() % size;
            return position;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                if (!Equals(data[i], default(T))) yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
         
         
    }
}
