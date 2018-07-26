using System;

// This program finds the sun of all the natural numbers below 1000 that are multiples of 3 or 5. 

namespace ConsoleApp
{
    class Program
    {
        static void Main()
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

            // Keep the console open after task completion
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
