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
        public static Answer Solution1()
        {
            Stopwatch sw = Stopwatch.StartNew();
            int a = 0, b = 0, c = 0;
            sw.Stop();
            return new Answer
            {
                Result = 0,
                TimeTaken = sw.Elapsed.TotalMilliseconds,
                ExtraInfo = $"{a}, {b}, {c}"
            };
        }
    }
}
