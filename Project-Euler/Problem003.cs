using System;

// This program finds the largest prime factor of the number 600851475143.
// The program prints each prime number starting from 1 until it reaches the maximum prime number.

namespace ProjectEuler
{
    class Problem003
    {
        public static void Solution()
        {
            double number = 600851475143;
            // Count until divisable number reached
            for (double i = 0; i < number / 2; i++)
            {
                // Check if i divided by number is a whole number
                if (number % i == 0)
                {
                    // Check if i is a prime number
                    if (IsPrime(i) == true)
                    {
                        // Print prime numbers
                        Console.WriteLine(i);
                    }
                }
            }
        }

        static bool IsPrime(double i)
        {
            for (Int64 n = 2; n < i; n++)
            {
                if (i % n == 0)
                {
                    return (false);
                }
            }
            return (true);
        }
    }
}
