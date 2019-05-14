using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ProjectEuler.Tests.Models.Sorts;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Sorts
    {
        private int[] numbers = new int[] { 1, 4, 9, 30, 27, 3, 8, 14, 12 };
        private int[] forward = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        private int[] backward = new int[] { 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        private int[] one = new int[] { 12 };
        private int[] two = new int[] { 15, 12 };

        /// <summary>
        /// Starting on the left, compare adjacent items and keep bubbling larger ones to the right.
        /// 
        /// Big O for bubble sort is O(n) to O(n^2)
        /// </summary>
        [TestMethod]
        public void BubbleSortTest()
        {
            int[] sorted = BubbleSort.Sort(numbers);

            Assert.AreEqual(sorted[0], 1);
            Assert.AreEqual(sorted[1], 3);
            Assert.AreEqual(sorted[2], 4);
            Assert.AreEqual(sorted[3], 8);
            Assert.AreEqual(sorted[4], 9);
            Assert.AreEqual(sorted[5], 12);
            Assert.AreEqual(sorted[6], 14);
            Assert.AreEqual(sorted[7], 27);
            Assert.AreEqual(sorted[8], 30);
        }

        /// <summary>
        /// Scan all items and find the smallest.  Swap it into position as the first item.
        /// 
        /// Big O for selection sort is O(n^2)
        /// </summary>
        [TestMethod]
        public void SelectionSortTest()
        {
            int[] sorted = SelectionSort.Sort(numbers);

            Assert.AreEqual(sorted[0], 1);
            Assert.AreEqual(sorted[1], 3);
            Assert.AreEqual(sorted[2], 4);
            Assert.AreEqual(sorted[3], 8);
            Assert.AreEqual(sorted[4], 9);
            Assert.AreEqual(sorted[5], 12);
            Assert.AreEqual(sorted[6], 14);
            Assert.AreEqual(sorted[7], 27);
            Assert.AreEqual(sorted[8], 30);
        }

        /// <summary>
        /// Start with a sorted list of 1 element on the left, and n-1 unsorted items on the right.
        /// Take the first unsorted item and insert it into the sorted list.
        /// 
        /// Big O for insertion sort is O(n) to O(n^2)
        /// </summary>
        [TestMethod]
        public void InsertionSortTest()
        {
            int[] sorted = InsertionSort.Sort(numbers);

            Assert.AreEqual(sorted[0], 1);
            Assert.AreEqual(sorted[1], 3);
            Assert.AreEqual(sorted[2], 4);
            Assert.AreEqual(sorted[3], 8);
            Assert.AreEqual(sorted[4], 9);
            Assert.AreEqual(sorted[5], 12);
            Assert.AreEqual(sorted[6], 14);
            Assert.AreEqual(sorted[7], 27);
            Assert.AreEqual(sorted[8], 30);
        }

        /// <summary>
        /// Pick a pivot item, partition all other items into a "greater than" sublist and a "less than" sublist.
        /// Recursively repeat on both sublists.  Repeat until all sublists are of size 1, then combine the sublists.
        /// 
        /// Big O for quicksort is O(n*log(n)) to O(n^2) (average: O(n*log(n))
        /// </summary>
        [TestMethod]
        public void QuickSortTest()
        {
            int[] sorted = QuickSort.Sort(numbers);

            Assert.AreEqual(sorted[0], 1);
            Assert.AreEqual(sorted[1], 3);
            Assert.AreEqual(sorted[2], 4);
            Assert.AreEqual(sorted[3], 8);
            Assert.AreEqual(sorted[4], 9);
            Assert.AreEqual(sorted[5], 12);
            Assert.AreEqual(sorted[6], 14);
            Assert.AreEqual(sorted[7], 27);
            Assert.AreEqual(sorted[8], 30);
        }

        /// <summary>
        /// Add all items into a heap.  Pop the largest item from the heap and insert it at the end.  Repeat for all items.
        /// 
        /// Big O for heapsort is O(n*log(n))
        /// </summary>
        [TestMethod]
        public void HeapSortTest()
        {

        }

        /// <summary>
        /// Assume items are integers in a range of 0-k (+x) where x is an offset.  Create an array of size k.
        /// ** Note:  This sort will not work unless the range of numbers is preserved.
        /// 
        /// Big O for counting sort is O(n)
        /// </summary>
        [TestMethod]
        public void CountingSortTest()
        {

        }

        /// <summary>
        /// Sort by one digit place at a time (ie:  move 1000-1999 ahead of 2000-2999)
        /// 
        /// Big O for heapsort is O(n)
        /// </summary>
        [TestMethod]
        public void RadixSortTest()
        {

        }
    }
}
