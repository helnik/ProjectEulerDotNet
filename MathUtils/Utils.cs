namespace MathUtils
{
    /// <summary>
    /// Usefull code for solving the EulerProject problems <br/>
    /// Code is duplicated so each problem file can be a stand alone
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Decides if a number is prime
        /// </summary>
        public static bool IsPrime(long number)
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

        /// <summary>
        /// Finds the Lowest Common Multiple (LCM)
        /// </summary>
        public static long GetLcm(long num1, int num2)
        {
            if (num1 == 0 || num2 == 0) return -1;
            return num1 / GetGcd(num1, num2) * num2;
        }

        /// <summary>
        /// Finds the Greatest Common Divison (GCD)
        /// </summary>
        public static long GetGcd(long num1, long num2)
        {
            if (num1 == 0 || num2 == 0) return -1;
            while (num2 != 0)
            {
                num1 %= num2;
                num1 ^= num2;
                num2 ^= num1;
                num1 ^= num2;
            }
            return num1;
        }

    }
}
