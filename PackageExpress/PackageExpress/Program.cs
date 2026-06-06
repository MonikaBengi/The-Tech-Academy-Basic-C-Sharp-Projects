using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            // Display welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");

            // Read the weight entered by the user and convert it to a decimal
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if the package is too heavy
            if (weight > 50)
            {
                // Display error message if weight exceeds the limit
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

                // End the program
                Console.ReadLine();
                return;
            }

            // Ask the user to enter the package width
            Console.WriteLine("Please enter the package width:");

            // Read the width entered by the user
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Ask the user to enter the package height
            Console.WriteLine("Please enter the package height:");

            // Read the height entered by the user
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Ask the user to enter the package length
            Console.WriteLine("Please enter the package length:");

            // Read the length entered by the user
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Calculate the total dimensions
            decimal totalDimensions = width + height + length;

            // Check if the package dimensions exceed the limit
            if (totalDimensions > 50)
            {
                // Display error message if dimensions are too large
                Console.WriteLine("Package too big to be shipped via Package Express.");

                // End the program
                Console.ReadLine();
                return;
            }

            // Calculate the shipping quote
            decimal quote = (width * height * length * weight) / 100;

            // Display the quote as a dollar amount with two decimal places
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

            // Thank the user
            Console.WriteLine("Thank you!");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}