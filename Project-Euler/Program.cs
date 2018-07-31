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
            Console.WriteLine("002 - Even Fibonacci numbers");
            Console.WriteLine("003 - Largest prime factor");
            Console.WriteLine("004 - Largest palindrome product");
            Console.WriteLine("005 - Smallest multiple");
            Console.WriteLine("006 - Sum square difference");
            Console.WriteLine("007 - 10001st prime");
            Console.WriteLine("008 - Largest product in a series");
            Console.WriteLine("0 to Exit");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Problem001.Solution();
                    break;
                case 2:
                    Problem002.Solution();
                    break;
                case 3:
                    Problem003.Solution();
                    break;
                case 4:
                    Problem004.Solution();
                    break;
                case 5:
                    Problem005.Solution();
                    break;
                case 6:
                    Problem006.Solution();
                    break;
                case 7:
                    Problem007.Solution();
                    break;
                case 8:
                    Problem008.Solution();
                    break;
                case 0:
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
            Main();
        }
    }
}
