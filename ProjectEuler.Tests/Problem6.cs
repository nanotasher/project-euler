using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Tests
{
	[TestClass]
	public class Problem6
	{
        /// <summary>
        /// The sum of the squares of the first ten natural numbers is,
        ///
        /// 1^2 + 2^2 + ... + 10^2 = 385
        /// The square of the sum of the first ten natural numbers is,
        ///
        /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
        /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        ///
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
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
