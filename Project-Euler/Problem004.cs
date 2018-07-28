using System;
using System.Linq;

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
                    // Find product of numbers and convert to char array
                    int c = a * b;
                    char[] p = c.ToString().ToCharArray();
                    char[] pr = c.ToString().ToCharArray();

                    // Reverse string and store in pr
                    for (int i = 0; i < p.Length; i++)
                    {
                        pr[i] = p[(p.Length - 1) - i];
                    }

                    // Check if product is a palindrome number and is greater than current highest
                    if (p.SequenceEqual(pr) && c > h)
                    {
                        // Store value and break
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
