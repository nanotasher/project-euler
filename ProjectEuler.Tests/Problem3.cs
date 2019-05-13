using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Problem3
    {
		private const ulong NUMBER = 600851475143;

		/// <summary>
		/// The prime factors of 13195 are 5, 7, 13 and 29.
		///
		/// What is the largest prime factor of the number 600851475143 ?
		/// </summary>
		[TestMethod]
        public void Run()
        {
            ulong largestFactor = 0;
			List<ulong> primeFactors = new List<ulong>();
			ulong n = NUMBER;
			ulong i = 2;

			while (i < n)
			{
				if (IsPrime(n))
				{
					primeFactors.Add(n);
					n = 0;
					continue;
				}
				else if (IsPrime(i))
				{
					if (n % i == 0)
					{
						primeFactors.Add(i);
						n /= i;
						i = 2;
						continue;
					}
				}

				i++;
			}

			for (int j = 0; j < primeFactors.Count; j++)
			{
				if (primeFactors[j] > largestFactor)
				{
					largestFactor = primeFactors[j];
				}
			}

            Assert.AreEqual((int)largestFactor, 6857);

			ulong sum = 1;
			for (int j = 0; j < primeFactors.Count; j++)
			{
				sum *= primeFactors[j];
			}

			Assert.AreEqual(sum, NUMBER);
        }

		private bool IsPrime(ulong number)
		{
			if (number <= 1) return false;
			if (number == 2) return true;
			if (number % 2 == 0) return false;

			var boundary = (ulong)Math.Floor(Math.Sqrt(number));

			for (ulong i = 3; i <= boundary; i += 2)
				if (number % i == 0)
					return false;

			return true;
		}
    }
}
