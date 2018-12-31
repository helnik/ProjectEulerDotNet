using System;
using System.Diagnostics;

namespace Problems
{
    /// <summary>
    /// Problem 7: 10001st prime
    /// Source: https://projecteuler.net/problem=7
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// What is the 10001st prime number?
    /// </summary>
    public static class Problem07
    {
        public static Answer Solution1(long number = 10001)
        {
            Stopwatch sw = Stopwatch.StartNew();
            long noOfPrime = 6, possible = 13, prime = 13;
            while (noOfPrime < number)
            {
                possible++;
                if (IsPrime(possible))
                {
                    noOfPrime++;
                    prime = possible;
                }
            }
            sw.Stop();
            return new Answer
            {
                Result = prime,
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
    }
}
