using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Problems
{
    /// <summary>
    /// Problem 10: Summation of primes
    /// Source: https://projecteuler.net/problem=10
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// Find the sum of all the primes below two million.
    /// </summary>
    public static class Problem10
    {
        #region Solution1
        public static Answer Solution1(long number = 2000000)
        {
            Stopwatch sw = Stopwatch.StartNew();
            long sum = 17;
            for (long i = 8; i < number; i++)
            {
                if (IsPrime(i))
                    sum += i;
            }
            sw.Stop();
            return new Answer
            {
                Result = sum,
                TimeTaken = sw.Elapsed.TotalMilliseconds
            };
        }

        private static bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            long i = 3;
            while (i * i <= number)
            {
                if (number % i == 0) return false;
                i += 2;
            }
            return true;
        }
        #endregion

        #region Solution2
        /// <summary>
        /// Solution using Sieve of eratosthenes
        /// </summary>
        public static Answer Solution2(long number = 2000000)
        {
            Stopwatch sw = Stopwatch.StartNew();
            long sum = 0;
            var primes = SieveOfEratosthenes((int) number);
            foreach (var p in primes)
                sum += p;
            sw.Stop();
            return new Answer
            {
                Result = sum,
                TimeTaken = sw.Elapsed.TotalMilliseconds,
                ExtraInfo = "Algorithm used = Sieve of Eratosthenes"
            };
        }

        /// <summary>
        /// Source: https://www.mathblog.dk/sum-of-all-primes-below-2000000-problem-10/
        /// </summary>
        private static IEnumerable<int> SieveOfEratosthenes(int upperLimit)
        {
            int sieveBound = (upperLimit - 1) / 2;
            int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;
            BitArray primeBits = new BitArray(sieveBound + 1, true);

            for (int i = 1; i <= upperSqrt; i++)
            {
                if (primeBits.Get(i))
                {
                    for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1)
                    {
                        primeBits.Set(j, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);

            for (int i = 1; i <= sieveBound; i++)
            {
                if (primeBits.Get(i))
                {
                    numbers.Add(2 * i + 1);
                }
            }
            return numbers;
        }
        #endregion
    }
}
