using System;
using System.Collections;
using System.Collections.Generic;

namespace MathUtils
{
    public static class Algorithms
    {
        /// <summary>
        /// Perfmors the sieve of eratosthenes to find prime numbers
        /// Source: https://www.mathblog.dk/sum-of-all-primes-below-2000000-problem-10/
        /// </summary>
        public static IEnumerable<int> SieveOfEratosthenes(int upperLimit)
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
    }
}
