using System;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object from the NumberMethods class.
            NumberMethods numbers = new NumberMethods();

            // Call the method and pass in two numbers.
            numbers.DoMath(6, 10);

            // Add a blank line between the two results.
            Console.WriteLine();

            // Call the same method using named parameters.
            numbers.DoMath(firstNumber: 8, secondNumber: 15);

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}