using System;

// This program finds the 10001st prime number.

namespace ProjectEuler
{
    class Problem007
    {
        public static void Solution()
        {
            // Find answer using my Find method from Prime.cs and output to console
            Console.WriteLine(Prime.Find(10001));
        }
    }
}
