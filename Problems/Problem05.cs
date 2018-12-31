using System.Diagnostics;

namespace Problems
{
    /// <summary>
    /// Problem 5: Smallest multiple
    /// Source: https://projecteuler.net/problem=5
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public static class Problem05
    {
        public static Answer Solution1()
        {
            Stopwatch sw = Stopwatch.StartNew();
            long result;
            for (long i = 2520;; i++)
            {
                if (!IsDividedByAll(i)) continue;
                result = i;
                break;
            }
            sw.Stop();

            return new Answer
            {
                Result = result,
                TimeTaken = sw.Elapsed.TotalMilliseconds
            };
        }

        private static bool IsDividedByAll(long i)
        {
            return (i % 11 == 0) && (i % 12 == 0) && (i % 13 == 0) && (i % 14 == 0) && (i % 15 == 0)
                && (i % 16 == 0) && (i % 17 == 0) && (i % 18 == 0) && (i % 19 == 0) && (i % 20 == 0);
        }

        /// <summary>
        /// Solution proposed in forum https://projecteuler.net/thread=5;page=2
        /// LCM Least Common Multiple
        /// GDM 
        /// </summary>
        public static Answer Solution2()
        {
            long result = 1;
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 1; i <= 20; i++)
                result = GetLcm(result, i);
            sw.Stop();

            return new Answer
            {
                Result = result,
                TimeTaken = sw.Elapsed.TotalMilliseconds
            };
        }

        private static long GetLcm(long result, int i)
        {
            return result / GetGcd(result, i) * i;
        }

        private static long GetGcd(long result, long i)
        {
            while (i != 0)
            {
                result %= i;
                result ^= i;
                i ^= result;
                result ^= i;
            }
            return result;
        }
    }
}
