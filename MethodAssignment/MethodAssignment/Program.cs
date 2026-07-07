using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object from the NumberCalculator class.
            NumberCalculator calculator = new NumberCalculator();

            // Ask the user for the first number.
            Console.WriteLine("Enter the first number:");

            // Convert the first input into an integer.
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            // Ask the user for the second number.
            Console.WriteLine("Enter the second number, or press Enter to skip:");

            // Read the second input as text.
            string secondInput = Console.ReadLine();

            // Check if the user entered a second number.
            if (secondInput == "")
            {
                // Call the method with one number only.
                int result = calculator.AddNumbers(firstNumber);

                // Display the result using the default second number.
                Console.WriteLine("Result using default number: " + result);
            }
            else
            {
                // Convert the second input into an integer.
                int secondNumber = Convert.ToInt32(secondInput);

                // Call the method with both numbers.
                int result = calculator.AddNumbers(firstNumber, secondNumber);

                // Display the result using both numbers.
                Console.WriteLine("Result using both numbers: " + result);
            }

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}