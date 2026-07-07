using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object from the Calculator class.
            Calculator calculator = new Calculator();

            // Call the method that accepts an integer.
            Console.WriteLine("Integer result: " + calculator.Calculate(8));

            // Call the method that accepts a decimal.
            Console.WriteLine("Decimal result: " + calculator.Calculate(12.6m));

            // Call the method that accepts a string.
            Console.WriteLine("String result: " + calculator.Calculate("20"));

            Console.ReadLine();
        }
    }
}