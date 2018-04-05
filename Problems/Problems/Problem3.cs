using System.Diagnostics;

namespace Problems
{
    /// <summary>
    /// Problem 3: Largest prime factor
    /// Source: https://projecteuler.net/problem=3
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?   
    /// Learn: To get an idea of factor calculation a read this article: https://www.mathsisfun.com/prime-factorization.html
    /// </summary>
    public static class Problem3
    {
        /// <summary>
        /// Initial thought. Really slow. Never let it end cause life.
        /// </summary>        
        public static Answer Solution1(long number = 600851475143)
        {
            Stopwatch sw = Stopwatch.StartNew();
            long largest = 2;
            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    bool isPrime = true;
                    for (long j = 2; j < i; j++)
                    {
                        if(i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime) largest = i;
                }
            }
            sw.Stop();

            return new Answer
            {
                Result = largest,
                TimeTaken = sw.Elapsed.TotalMilliseconds
            };
        }

        /// <summary>
        /// Based on Fundamental Theorem of Arithmetic : There is only one (unique!) set of prime factors for any number.
        /// We start with 2, and check how many times that number is divisible with the remainder we have. 
        /// Once 2 is not a divisor to the remainder we increase the counter by one and check 3 then all primes. 
        /// If 4 was a factor to the original number, 2 will be a factor at least twice as well. 
        /// And then we can go on, until the counter is larger than the square root of the remainder.
        /// f the remainder is different from one, then the remainder is also a prime factor. 
        /// However I only need to check if it is larger than the largest factor found, to see if it is interesting.
        /// Source: https://www.mathblog.dk/project-euler-problem-3/
        /// </summary>        
        public static Answer Solution2(long number = 600851475143)
        {
            Stopwatch sw = Stopwatch.StartNew();
            long newnumm = number;
            long largest = 2;

            int counter = 2;
            while (counter * counter <= newnumm)
            {
                if (newnumm % counter == 0)
                {
                    newnumm = newnumm / counter;
                    largest = counter;
                }
                else
                    //f the counter is two, we increase it to 3, otherwise we increase it by 2 so we only check 2 and the odd numbers.
                    counter = (counter == 2) ? 3 : counter + 2;
            }
            if (newnumm > largest)            
                largest = newnumm;
            sw.Stop();
            return new Answer
            {
                Result = largest,
                TimeTaken = sw.Elapsed.TotalMilliseconds
            };
        }

    }
}
