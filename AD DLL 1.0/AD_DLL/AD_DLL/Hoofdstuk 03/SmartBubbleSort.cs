using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DLL.Hoofdstuk_03
{
    class SmartBubbleSort
    {
        /// <summary>
        /// Smart bubble sort
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="array">arrayay of generic type</param>
        public static T[] smartBubbleSort<T>(T[] array) where T : IComparable<T>
        {
            // tijdelijke variable die we gebruiken om de swap te regelen
            T temp;

            // instantieer flag , zodat we kunnen aangeven wanneer er geen veranderingen meer zijn
            // zodat de methode kan stoppen
            bool flag;

            // loop door de elementen
            for (int o = array.Length - 1; o >= 1; o--)
            {
                // instantieer flag = false, zodat we kunnen aangeven wanneer er geen verandering meer
                // kunnen worden doorgevoerd hierdoor is de smart bubble sort net iets sneller
                flag = false;

                // pak het getal
                for (int i = 0; i <= o - 1; i++)
                {
                    // check om te kijken of het volgende getal groter i
                    if (array[i].CompareTo(array[i + 1]) <= 0)
                    {
                        // ruil de getallen om als het door de check heen is                        
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        // geef verandering aan
                        flag = true;
                    }

                    // als er niks is veranderd zal de array worden gereturned
                    if (flag == false)
                    {
                        return array;
                    }
                }
            }
            return array;
        }
    }
}
