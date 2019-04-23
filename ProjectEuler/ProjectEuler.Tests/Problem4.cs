using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectEuler.Tests
{
	[TestClass]
	public class Problem4
	{
		/// <summary>
		/// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
		///
		/// Find the largest palindrome made from the product of two 3-digit numbers.
		/// </summary>
		[TestMethod]
		public void Run()
		{
			Assert.IsTrue(IsPalindromic(906609));
			Assert.IsFalse(IsPalindromic(906509));
			Assert.IsTrue(IsPalindromic(9064609));
			Assert.IsFalse(IsPalindromic(1111121111111));

			int largest = 0;
			for (int i = 999; i >= 100; i--)
			{
				for (int j = 999; j >= 100; j--)
				{
					if (IsPalindromic((ulong)(i * j)))
					{
						if (i * j > largest)
						{
							largest = i * j;
						}
					}
				}
			}

			Assert.AreEqual(largest, 906609);
		}

		private bool IsPalindromic(ulong number)
		{
			String stringNumber = number.ToString();

			if (stringNumber.Length < 2)
				return false;

			for (int i = 0; i < Math.Floor((decimal)stringNumber.Length / 2); i++)
			{
				if (stringNumber[i] != stringNumber[stringNumber.Length - i - 1])
				{
					return false;
				}
			}

			return true;
		}
	}
}
