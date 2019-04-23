using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Tests
{
	[TestClass]
	public class Problem6
	{
		/// <summary>
		/// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
		///
		/// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
		/// </summary>
		[TestMethod]
		public void Run()
		{
			int test = 10;

			long sumOfSquares = SumOfSquares(test);
			long squareOfSums = SquareOfSums(test);

			Assert.AreEqual(385, sumOfSquares);
			Assert.AreEqual(3025, squareOfSums);

			test = 100;

			sumOfSquares = SumOfSquares(test);
			squareOfSums = SquareOfSums(test);

			Assert.AreEqual(338350, sumOfSquares);
			Assert.AreEqual(25502500, squareOfSums);

			long diff = squareOfSums - sumOfSquares;
			Assert.AreEqual(diff, 25164150);
		}

		private long SumOfSquares(int test)
		{
			long result = 0;

			for (int i = 1; i <= test; i++)
			{
				result += (long)Math.Pow(i, 2);
			}

			return result;
		}

		private long SquareOfSums(int test)
		{
			long result = 0;

			for (int i = 1; i <= test; i++)
			{
				result += i;
			}

			return (long)Math.Pow(result, 2);
		}
	}
}
