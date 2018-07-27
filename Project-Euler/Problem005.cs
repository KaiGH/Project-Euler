using System;

// This program finds the smallest positive number that is evenly divisible by all of the numbers from 1 to 20

namespace ProjectEuler
{
    class Problem005
    {
        public static void Solution()
        {
            // Increment over positive numbers starting from 2520 (provided by Euler example)
            for (int i = 2520; true; i++)
            {
                int nondivisibles = 0;
                // Increment over numbers to divide by
                for (int n = 1; n <= 20; n++)
                {
                    // Check if number is evenly divisible by 1 -> 20
                    if (i % n != 0)
                    {
                        // Count of numbers not evenly divisible
                        nondivisibles++;
                    }
                }
                // If all are evenly divisible output result to the console
                if (nondivisibles == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
