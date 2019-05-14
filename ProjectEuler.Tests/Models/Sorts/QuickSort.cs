using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Tests.Models.Sorts
{
    public static class QuickSort
    {
        public static int[] Sort(int[] numbers)
        {
            int[] sorted = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                sorted[i] = numbers[i];
            }

            SortInternal(sorted, 0, numbers.Length - 1);

            return sorted;
        }

        private static void SortInternal(int[] numbers, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = Partition(numbers, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                SortInternal(numbers, low, pi - 1);
                SortInternal(numbers, pi + 1, high);
            }
        }

        private static int Partition(int[] numbers, int low, int high)
        {
            int pivot = numbers[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (numbers[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            i++;

            int temp1 = numbers[i];
            numbers[i] = numbers[high];
            numbers[high] = temp1;

            return i;
        }
    }
}
