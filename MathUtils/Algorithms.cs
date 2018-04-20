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

        /// <summary>
        /// Performs an Atkin sieve to find primes.
        /// Source: https://github.com/SuprDewd/SharpBag
        /// </summary>
        public static IEnumerable<ulong> SieveOfAtkin(ulong max)
        {
            var isPrime = new bool[max + 1];
            var sqrt = Math.Sqrt(max);

            for (ulong x = 1; x <= sqrt; x++)
            for (ulong y = 1; y <= sqrt; y++)
            {
                var xsq = x * x;
                var ysq = y * y;
                var n = 4 * xsq + ysq;

                if (n <= max && (n % 12 == 1 || n % 12 == 5))
                    isPrime[n] ^= true;

                n = 3 * xsq + ysq;
                if (n <= max && n % 12 == 7)
                    isPrime[n] ^= true;

                n = 3 * xsq - ysq;
                if (x > y && n <= max && n % 12 == 11)
                    isPrime[n] ^= true;
            }

            for (ulong n = 5; n <= sqrt; n++)
                if (isPrime[n])
                {
                    var s = n * n;
                    for (ulong k = s; k <= max; k += s)
                        isPrime[k] = false;
                }

            yield return 2;
            yield return 3;
            for (ulong n = 5; n <= max; n += 2)
                if (isPrime[n]) yield return n;
        }
    }
}
