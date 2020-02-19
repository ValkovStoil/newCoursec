using System;
using static System.Console;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 43;
            int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            WriteLine("Our array contains:");
            Array.ForEach(array, x => Write($"{x} "));

            Write($"\n\nThe result of a binary search for{theValue} is: ");
            WriteLine(binarySearch(array, theValue));
        }
        /// <summary>
        /// a = array
        /// x = wha we'ar searching
        /// p = first index
        /// q = midpoint
        /// r = last index
        /// </summary>
        public static int binarySearch(int[] a, int x)
        {
            // Step 1 - initialize the variables
            int p = 0; // begining of the range
            int r = a.Length - 1; // the end of the range aka last sot

            // Step 2 - we do somthing (search for our value)
            while (p <= r)
            {
                int q = (p + r) / 2; // find midpoint
                if (x < a[q])
                {
                    r = q - 1;      // set r to midpoint. We narrowed to 1st
                                    // half of the array in the case x i sless
                                    // the data in slot q
                }
                else if (x > a[q])
                {
                    p = q + 1;      // the opposite occurs. We bring p to the
                                    // right of the array

                }
                else
                {
                    return q;
                }
            }

            // Step 3 - indicate not fund
            return -1;
        }
    }
}
