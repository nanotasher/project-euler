using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Problem7
    {
        /// <summary>
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        ///
        /// What is the 10 001st prime number?
        /// </summary>
        [TestMethod]
        public void Run()
        {
            long answer = 0;

            int cnt = 0;
            int test = 1;

            while (cnt < 10001)
            {
                if (IsPrime(++answer)) cnt++;
            }

            Assert.AreEqual(answer, 104743);
        }

        private bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            long boundary = (long)Math.Floor(Math.Sqrt(number));

            for (long i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
