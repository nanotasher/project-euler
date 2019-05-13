using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Tests.Models.Sorts
{
    public static class InsertionSort
    {
        /// <summary>
        /// Insertion sort is a simple sorting algorithm that works the way we sort playing cards in our hands.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int[] Sort(int[] numbers)
        {
            int[] sorted = new int[numbers.Length];

            //  populate sorted array -- don't use numbers after this
            for (int i = 0; i < numbers.Length; i++)
            {
                sorted[i] = numbers[i];
            }

            //  sort the array
            int n = sorted.Length;
            for (int i = 1; i < n; i++)
            {
                int t = sorted[i];
                int j = i - 1;

                //  push all elements up one
                while (j >= 0 && sorted[j] > t)
                {
                    sorted[j + 1] = sorted[j];
                    j = j - 1;
                }
                //  insert the element where it belongs
                sorted[j + 1] = t;
            }

            return sorted;
        }
    }
}
