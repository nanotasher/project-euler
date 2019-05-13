using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Tests.Models.Sorts
{
    /// <summary>
    /// Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order.
    /// 
    /// Big O for bubble sort is O(n) to O(n^2)
    /// </summary>
    public static class BubbleSort
    {
        public static int[] Sort(int[] numbers)
        {
            bool sorted = false;
            int t = 0;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i < numbers.Length - 1)
                    {
                        if (numbers[i] > numbers[i+1])
                        {
                            sorted = false;
                            t = numbers[i + 1];
                            numbers[i + 1] = numbers[i];
                            numbers[i] = t;

                            break;
                        }
                    }
                }
            }

            return numbers;
        }
    }
}
