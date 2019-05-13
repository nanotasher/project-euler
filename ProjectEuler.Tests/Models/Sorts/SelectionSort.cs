using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Tests.Models.Sorts
{
    /// <summary>
    /// The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) 
    /// from unsorted part and putting it at the beginning. The algorithm maintains two subarrays in a given array.
    /// </summary>
    public static class SelectionSort
    {
        public static int[] Sort(int[] numbers)
        {
            List<int> sorted = new List<int>(numbers.Length);
            List<int> unsorted = new List<int>(numbers.Length);

            //  set initial state of unsorted
            for (int i = 0; i < numbers.Length; i++)
            {
                unsorted.Add(numbers[i]);
            }

            //  loop through unsorted, removing the minimum element each run
            while (unsorted.Count > 0)
            {
                int min = Int32.MaxValue;
                int index = 0;

                //  find minimum value
                for (int i = 0; i < unsorted.Count; i++)
                {
                    if (unsorted[i] < min)
                    {
                        min = unsorted[i];
                        index = i;
                    }
                }

                sorted.Add(min);
                unsorted.RemoveAt(index);
            }

            return sorted.ToArray();
        }
    }
}
