using System;

namespace Calcshet
{
    class Program
    {
        static void main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            
            Console.WriteLine("Enter a number, and then press Enter: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter another number, and then press Enter: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Choose an operation from the following list:");
            Console.WriteLine("\ta - Addition");
            Console.WriteLine("\ts - Subtraction");
            Console.WriteLine("\tm - Multiplication");
            Console.WriteLine("\td - Division");
            Console.Write("What operation would you like to execute? ");

            
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}