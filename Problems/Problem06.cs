using System.Diagnostics;

namespace Problems
{
    /// <summary>
    /// Problem 6: Sum square difference
    /// Source: https://projecteuler.net/problem=6
    /// The sum of the squares of the first ten natural numbers is,
    /// 1^2 + 2^2 + ... + 10^2 = 385
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)^2 = 55^2 = 3025
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    public static class Problem06
    {
        public static Answer Solution1(long number = 100)
        {
            Stopwatch sw = Stopwatch.StartNew();
            long naturalsSquaresSummed = 0, naturalsSum = 0;
            for (long i = 1; i <= number; i++)
            {
                naturalsSquaresSummed += i * i;
                naturalsSum += i;
            }
            sw.Stop();
            return new Answer
            {
                Result = (naturalsSum * naturalsSum) - naturalsSquaresSummed,
                TimeTaken = sw.Elapsed.TotalMilliseconds
            };
        }

        /// <summary>
        /// Sum of all naturals is S(n) = n(n+1)/2
        /// Sum of all squares is S(n^2) = n(n+1)(2n+1)/6 
        /// Sum of all squares combining sum of all = (((2n+1)*S(n))/3
        /// </summary>
        public static Answer Solution2(long number = 100)
        {
            Stopwatch sw = Stopwatch.StartNew();
            long naturalsSum = (number * (number + 1)) / 2;
            long naturalsSquaresSummed = (((2 * number) + 1) * naturalsSum) / 3;
            
            sw.Stop();
            return new Answer
            {
                Result = (naturalsSum * naturalsSum) - naturalsSquaresSummed,
                TimeTaken = sw.Elapsed.TotalMilliseconds
            };
        }
    }
}
