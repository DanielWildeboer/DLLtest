using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DLL.Hoofdstuk_03
{
    public static class BubbleSort
    {

        /// <summary>
        /// BubbleSort class, deze sorteer functie pakt een getal en vergelijkt dat met het volgende getal
        /// Op die manier wijst het dan de plekken toe todat alles op volgorde staat
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// 
        public static T[] bubbleSort<T>(T[] array) where T : IComparable<T>
        {
            // tijdelijke variable die we gebruiken om de swap te regelen
            T temp;

            // loop door de elementen
            for (int o = array.Length - 1; o >= 1; o--)
            {
                // pak het getal
                for (int i = 0; i <= o - 1; i++)
                {
                    // check om te kijken of het volgende getal groter is
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        // ruil de getallen om als het door de check heen is
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
