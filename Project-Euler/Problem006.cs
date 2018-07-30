using System;

// This program finds the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

namespace ProjectEuler
{
    class Problem006
    {
        public static void Solution()
        {
            // Calculate the sum of the first 100 natural numbers
            double sum = 0, square = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i; // Sum unsquared numbers
                square += Math.Pow(i, 2); // Sum squared numbers
            }

            // Calculate the square of the sum
            sum = Math.Pow(sum, 2);
            
            // Print difference
            Console.WriteLine(sum - square);
        }
    }
}
