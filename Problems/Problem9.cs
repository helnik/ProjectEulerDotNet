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
        /// <summary>
        ///  a &lt; b &lt; c and a &lt sum/3 b &lt; sum/2, 
        /// </summary>        
        public static Answer Solution1(long number = 1000)
        {
            Stopwatch sw = Stopwatch.StartNew();
            long a = 0, b = 0, c = 0, sum = number;
            bool partsFound = false;
            
            for (a = 1; a < (sum / 3); a++)
            {
                for (b = a; b < (sum / 2); b++)
                {
                    c = sum - a - b;
                    if ((a * a) + (b * b) == (c * c))
                    {
                        partsFound = true;
                        break;
                    }
                }
                if (partsFound) break;
            }              

            sw.Stop();
            return new Answer
            {
                Result = a * b * c,
                TimeTaken = sw.Elapsed.TotalMilliseconds,
                ExtraInfo = $"{a}, {b}, {c}"
            };
        }
    }
}
