using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an array of whole numbers.
        int[] numbers = { 10, 20, 35, 50, 75, 100 };

        try
        {
            // Ask the user to type a number.
            Console.WriteLine("Please enter a whole number to divide the list by:");

            // Convert the user's answer from text to an integer.
            int divisor = Convert.ToInt32(Console.ReadLine());

            // Loop through every number in the array.
            foreach (int number in numbers)
            {
                // Divide the current number by the user's number.
                int result = number / divisor;

                // Display the calculation result.
                Console.WriteLine(number + " divided by " + divisor + " equals " + result);
            }
        }
        catch (FormatException)
        {
            // This runs if the user types text instead of a whole number.
            Console.WriteLine("Error: Please type a valid whole number.");
        }
        catch (DivideByZeroException)
        {
            // This runs if the user types 0.
            Console.WriteLine("Error: You cannot divide by zero.");
        }
        catch (Exception ex)
        {
            // This catches any other unexpected error.
            Console.WriteLine("Unexpected error: " + ex.Message);
        }

        // This line proves the program continued after the try/catch block.
        Console.WriteLine("The program has continued after the try/catch block.");

        // Keep the console window open.
        Console.ReadLine();
    }
}