using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Tests
{
	[TestClass]
	public class Problem5
	{
		/// <summary>
		/// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
		///
		/// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
		/// </summary>
		[TestMethod]
		public void Run()
		{
			int test = 20;
			List<Tuple<int, int>> primeFactors = new List<Tuple<int, int>>();
			Dictionary<int, int> combinedPrimeFactors = new Dictionary<int, int>();

			//  Create all possible prime factorizations from 1 to x
			for (int i = 1; i <= test; i++)
			{
				List<Tuple<int, int>> tmp = GetPrimeFactors(i);
				primeFactors.AddRange(tmp);
			}

			//  Combine and use the prime factor with the highest power
			foreach (Tuple<int, int> tuple in primeFactors)
			{
				if (combinedPrimeFactors.ContainsKey(tuple.Item1))
				{
					if (combinedPrimeFactors[tuple.Item1] < tuple.Item2)
					{
						combinedPrimeFactors[tuple.Item1] = tuple.Item2;
					}
				}
				else
				{
					combinedPrimeFactors.Add(tuple.Item1, tuple.Item2);
				}
			}

			//  Multiply the results together
			int result = 1;
			foreach (int key in combinedPrimeFactors.Keys)
			{
				result *= (int)Math.Pow(key, combinedPrimeFactors[key]);
			}

			Assert.AreEqual(result, 232792560);
		}

		private List<Tuple<int, int>> GetPrimeFactors(int test)
		{
			List<Tuple<int, int>> primeFactors = new List<Tuple<int, int>>();

			if (test >= 2)
			{
				int t = test;

				for (int i = 2; i <= test; i++)
				{
					int pow = 1;
					if (t % i == 0)
					{
						while (t % (int)Math.Pow(i, ++pow) == 0) ;

						t = t / (int)Math.Pow(i, --pow);

						primeFactors.Add(new Tuple<int, int>(i, pow));
					}
				}
			}

			return primeFactors;
		}
	}
}
