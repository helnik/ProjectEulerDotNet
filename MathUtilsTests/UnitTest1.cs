using System.Collections.Generic;
using MathUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathUtilsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsPrime()
        {
            List<int> numbers = new List<int>{ 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
                41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113,
                127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199,
                211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271 };

            foreach (var num in numbers)
                Assert.IsTrue(Utils.IsPrime(num));

            numbers = new List<int> {0, 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 22, 24, 25, 30, 100, 102, 5000};
            foreach (var num in numbers)
                Assert.IsFalse(Utils.IsPrime(num));
        }

        [TestMethod]
        public void TestGetGcd()
        {
            //https://en.wikipedia.org/wiki/Greatest_common_divisor
            Assert.IsTrue(Utils.GetGcd(54, 24) == 6);
            Assert.IsTrue(Utils.GetGcd(0,0) == -1);
            Assert.IsTrue(Utils.GetGcd(0,1) == -1);
            Assert.IsTrue(Utils.GetGcd(42,56) == 14);
            Assert.IsTrue(Utils.GetGcd(9, 28) == 1); //coprimes
        }

        [TestMethod]
        public void TestGetLcm()
        {
            //https://www.calculatorsoup.com/calculators/math/lcm.php
            Assert.IsTrue(Utils.GetLcm(65, 10) == 130);
            Assert.IsTrue(Utils.GetLcm(0, 0) == -1);
            Assert.IsTrue(Utils.GetLcm(0, 140) == -1);
            Assert.IsTrue(Utils.GetLcm(1, 125) == 125);
            Assert.IsTrue(Utils.GetLcm(987, 525) == 24675);
        }
    }
}
