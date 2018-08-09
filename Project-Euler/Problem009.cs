using System;

// This program finds the one Pythagorean triplet for which a + b + c = 1000.

namespace ProjectEuler
{
    class Problem009
    {
        public static void Solution()
        {
            for (int a = 1; a <= 1000; a++)
            {
                for (int b = 1; b <= 1000; b++)
                {
                    // Find c^2, the product of a^2 + b^2
                    int c = (a * a) + (b * b);

                    // Check if a + b + c is 1000
                    if (a + b + Math.Pow(c, 0.5) == 1000)
                    {
                        // Find the product of a * b * c
                        Console.WriteLine(a * b * Math.Pow(c, 0.5));
                    }
                }
            }
        }
    }
}
