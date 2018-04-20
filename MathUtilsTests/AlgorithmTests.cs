using System.Collections.Generic;
using System.Linq;
using MathUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathUtilsTests
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void TestSieveOfEratosthenes()
        {
            List<int> numbers = new List<int>{ 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
                41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113,
                127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199,
                211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271 };

            var result = Algorithms.SieveOfEratosthenes(271);
            Assert.IsTrue(numbers.SequenceEqual(result));
        }

        [TestMethod]
        public void TestSieveOfAtkin()
        {
            List<ulong> numbers = new List<ulong>{ 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
                41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113,
                127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199,
                211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271 };

            var result = Algorithms.SieveOfAtkin(271);
            Assert.IsTrue(numbers.SequenceEqual(result));
        }
    }
}
