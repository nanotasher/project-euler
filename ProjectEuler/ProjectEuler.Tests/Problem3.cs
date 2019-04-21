using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Problem3
    {
        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        ///
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        [TestMethod]
        public void Run()
        {
            long largestFactor = 0;

            Assert.AreEqual(largestFactor, 6857);
        }
    }
}
