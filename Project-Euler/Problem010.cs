using System;

// This program finds the sum of all the primes below two million..

namespace ProjectEuler
{
    class Problem010
    {
        public static void Solution()
        {
            Int64 sum = 0;

            // Increment until 2 million reached
            for (int i = 0; i <= 2000000; i++)
            {
                // Check if i is a prime number using my Prime.Check method
                if (Prime.Check(i) == true)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
