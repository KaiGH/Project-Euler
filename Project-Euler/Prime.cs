using System;

// This class provides logic for working with prime numbers to reduce duplicated code

namespace ProjectEuler
{
    class Prime
    {
        public static bool Check(Int64 n)
        {
            // Reduce calculation time by skipping definite non-primes
            if (n == 0 || n == 1) { return (false); }
            if (n == 2 || n == 3 || n == 5) { return (true); }
            if (n % 2 == 0) { return (false); }
            if (n % 3 == 0) { return (false); }
            if (n % 5 == 0) { return (false); }

            // Check if number can be formed using two smaller numbers greater than 1
            for (Int64 i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) { return (false); }
            }
            return (true);
        }

        public static Int64 Find(int n)
        {
            // Initialise variables
            Int64 count = 0, found = 0, prime = 0;

            // Iterate until n
            while (found < n)
            {
                count++;
                // Check if its a prime number using my method from Prime.cs
                if (Check(count) == true) { found++; prime = count; };
            }
            return (prime);
        }
    }
}
