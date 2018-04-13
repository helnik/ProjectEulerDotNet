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
    }
}
