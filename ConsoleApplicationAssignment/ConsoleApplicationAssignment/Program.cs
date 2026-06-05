using System;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number and multiply it by 50
            Console.WriteLine("Enter a number:");
            long number1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Result: " + (number1 * 50));

            // Ask the user for a number and add 25
            Console.WriteLine("Enter another number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: " + (number2 + 25));

            // Ask the user for a number and divide it by 12.5
            Console.WriteLine("Enter another number:");
            double number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + (number3 / 12.5));

            // Ask the user for a number and check if it is greater than 50
            Console.WriteLine("Enter another number:");
            int number4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Greater than 50? " + (number4 > 50));

            // Ask the user for a number and display the remainder after dividing by 7
            Console.WriteLine("Enter another number:");
            int number5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Remainder: " + (number5 % 7));

            // Keep the console window open
            Console.ReadLine();
        }
    }
}