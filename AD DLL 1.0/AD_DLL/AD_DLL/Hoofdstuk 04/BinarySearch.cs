using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_DLL.Hoofdstuk_04
{
    public static class BinarySearch
    {
        public static int binarySearchArrayList<T>(this T[] arr, int value) where T : IComparable<T>
        {

            int upperBound, lowerBound, mid;
            upperBound = arr.Length - 1;
            lowerBound = 0;
            int compCount = 0;

            Console.Write("The search value: " + value + Environment.NewLine);
            Console.Write("The length of the array: " + upperBound + Environment.NewLine);
            while (lowerBound <= upperBound)
            {
                Console.Write("The lowerBound value: " + lowerBound + Environment.NewLine);
                Console.Write("The upperBound value: " + upperBound + Environment.NewLine);

                mid = (upperBound + lowerBound) / 2;
                Console.Write("Calculate the middle number: " + mid + Environment.NewLine);

                if (int.Parse(arr[mid].ToString()) == value)
                {
                    compCount++;
                    Console.Write("The number we're looking for: " + mid + Environment.NewLine);
                    Console.Write("Count: " + compCount + Environment.NewLine);
                    return mid;
                }
                else if (value < int.Parse(arr[mid].ToString()))
                {
                    compCount++;
                    upperBound = mid - 1;
                    Console.Write("Number too high: " + mid + Environment.NewLine);
                }
                else
                {
                    compCount++;
                    lowerBound = mid + 1;
                    Console.Write("Number too low: " + mid + Environment.NewLine);
                }
            }
            return -1;
        }
    }
}
