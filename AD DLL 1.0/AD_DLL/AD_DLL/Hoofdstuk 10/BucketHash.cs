using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DLL.Hoofdstuk_10
{
    public class BucketHash
    {
        private const int size = 100;
        ArrayList[] data;
                
        // De arraylist wordt gevuld met meerdere arraylisten. 
        
        public BucketHash()
        {
            data = new ArrayList[size];
            for (int i = 0; i <= size - 1; i++)
            {
                data[i] = new ArrayList(4);
            }
        }

        // De in te voeren waarde wordt gebruikt om te hashen. 
        // <param name="s"> Is de waarde die gehasht moet worden</param>
        // <returns>Totaal van de hashwaarde(index) waar de ingevoerde string moet worden opgeslagen</returns>


        public int Hash(string s)
        {
            long tot = 0;
            char[] charArray;
            charArray = s.ToCharArray();

            for (int i = 0; i <= s.Length - 1; i++)
            {
                int tempval = Convert.ToInt32(tot);
                tot += 37 * tempval + (int)charArray[i];
            }

            tot = tot % data.GetUpperBound(0);
            if (tot < 0)
            {
                tot += data.GetUpperBound(0);
            }

            return (int)tot;
        }

        // Items worden toegevoegd
        // <param name="item">De item die toegevoegd wordt</param>

        public void Insert(string item)
        {
            int hash_value;
            hash_value = Hash(item);
            if (data[hash_value].Contains(item))
            {
                data[hash_value].Add(item);
            }
        }

        // Items worden verwijderd 
        // <param name="item"> Item die verwijderd moet worden</param>


        public void Remove(string item)
        {
            int hash_value;
            hash_value = Hash(item);
            if (data[hash_value].Contains(item))
            {
                data[hash_value].Remove(item);
            }
        }
    }
}
