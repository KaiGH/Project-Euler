using System;

// This program uses the Fibonacci sequence up to four million and finds the sum of the even-valued terms.

namespace ProjectEuler
{
    class Problem002
    {
        public static void Solution()
        {
            int sum = 0, result = 0, term1 = 0, term2 = 1;

            // Fibonacci sequence
            while (sum < 4000000)
            {
                sum = term1 + term2;

                // Add even numbers
                if (sum % 2 == 0)
                {
                    result += sum;
                }

                term1 = term2;
                term2 = sum;
            }

            // Print result
            Console.WriteLine(result);
        }
    }
}
