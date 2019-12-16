using System;

namespace Calcshet
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;


            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");


            Console.WriteLine("Enter a number, and then press Enter: ");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter another number, and then press Enter: ");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Choose an operation from the following list:");
            Console.WriteLine("\t1 - Addition");
            Console.WriteLine("\t2 - Subtraction");
            Console.WriteLine("\t3 - Multiplication");
            Console.WriteLine("\t4 - Division");
            Console.Write("What operation would you like to execute? ");


            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "4":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}