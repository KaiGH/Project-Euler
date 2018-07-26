using System;

// This program finds the sun of all the natural numbers below 1000 that are multiples of 3 or 5. 

namespace ProjectEuler
{
    class Problem001
    {
        public static void Solution()
        {
            int number = 0;

            // Find numbers that are multiples of 3 or 5
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    number += i;
                }
            }

            // Print result
            Console.WriteLine(number);
        }
    }
}
