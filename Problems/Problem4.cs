using System.Diagnostics;
using System.Linq;

namespace Problems
{
    /// <summary>
    /// Problem 4: Largest palindrome product
    /// Source: https://projecteuler.net/problem=4
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public static class Problem4
    {
        public static Answer Solution1()
        {
            Stopwatch sw = Stopwatch.StartNew();
            int palindrome = 0;
            for (int i = 999; i >= 100; i--)
            {
                for (int j = i; j >= 100; j--) // i * j == j * i
                {
                    var res = i * j;
                    if (IsPalindrome(res) && res > palindrome)
                        palindrome = res;
                }
            }
            sw.Stop();

            return new Answer
            {
                Result = palindrome,
                TimeTaken = sw.Elapsed.TotalMilliseconds
            };
        }

        private static bool IsPalindrome(int number)
        {
            var reversed = new string(number.ToString().ToCharArray().Reverse().ToArray());
            return number.ToString().Equals(reversed);
        }
    }
}
