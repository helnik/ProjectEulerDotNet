using System.Diagnostics;

namespace Problems
{
    /// <summary>
    /// Problem 9: Special Pythagorean triplet
    /// Source: https://projecteuler.net/problem=9
    /// A Pythagorean triplet is a set of three natural numbers, a &lt; b &lt; c, for which,
    /// a^2 + b^2 = c^2
    /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    public static class Problem9
    {
        public static Answer Solution1()
        {
            Stopwatch sw = Stopwatch.StartNew();
            int a  = 0, b = 0, c = 0;
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
