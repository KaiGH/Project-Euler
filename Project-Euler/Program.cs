using System;

// This program lets the user select which Project Euler problem they want to run

namespace ProjectEuler
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to run the Project Euler problem");
            Console.WriteLine("001 - Multiples of 3 and 5");

            input();
        }

        static void input()
        {
            int UserInput = Convert.ToInt32(Console.ReadLine());
            output(UserInput);
        }

        static void output(int UserInput)
        {
            if (UserInput < 2 && UserInput > 0)
            {
                if (UserInput == 1) { Problem001.Solution(); }
                input();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                input();
            }
        }
    }
}
