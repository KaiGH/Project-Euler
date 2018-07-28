using System;

// This program finds the largest palindrome made from the product of two 3-digit numbers.

namespace ProjectEuler
{
    class Problem004
    {
        public static void Solution()
        {
            int h = 0;
            // First 3-digit number
            for (int a = 999; a >= 100; a--)
            {
                // Second 3-digit number
                for (int b = 999; b >= 100; b--)
                {
                    // Find product of numbers and convert to string
                    int c = a * b;
                    string p = c.ToString();

                    // Check if product is 5 charaters and a palindrome number and is greater than current highest
                    if (p.Length == 6 && p[0] == p[5] && p[1] == p[4] && p[2] == p[3] && c > h)
                    {
                        // Store value and break
                        h = c;
                        break;
                    }
                    if (p.Length == 5 && p[0] == p[4] && p[1] == p[3] && c > h)
                    {
                        h = c;
                        break;
                    }
                }
            }
            // Print result
            Console.WriteLine(h);
        }
    }
}
