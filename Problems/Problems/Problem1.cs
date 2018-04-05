using System.Diagnostics;

namespace Problems
{
    /// <summary>
    /// Source: https://projecteuler.net/problem=1
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public static class Problem1
    {
        public static Answer Solution1(long number = 1000)
        {
            Stopwatch sw = Stopwatch.StartNew();
            long sum = 0;
            for (int i = 3; i < number; i++)
                if ((i % 3 == 0) || (i % 5 == 0))
                    sum += i;
            sw.Stop();

            return new Answer
            {
                Result = sum,
                TimeTaken = sw.Elapsed.TotalMilliseconds
            };
        }

        /// <summary>
        /// 1 + 2 + ... + n = n*(n+1)/2
        /// taken from https://stackoverflow.com/a/26828231 3rd approach
        /// </summary>
        /// <returns></returns>
        public static Answer Solution2()
        {
            Stopwatch sw = Stopwatch.StartNew();
            int nr = 1000 - 1;            
            int x3 = nr / 3;
            int x5 = nr / 5;
            int x15 = nr / 15;

            long sum1 = 3 * x3 * (x3 + 1);
            long sum2 = 5 * x5 * (x5 + 1);
            long sum3 = 15 * x15 * (x15 + 1);

            long sum = (sum1 + sum2 - sum3) / 2;
            sw.Stop();

            return new Answer
            {
                Result = sum,
                TimeTaken = sw.Elapsed.TotalMilliseconds
            };
        }
    }
}
