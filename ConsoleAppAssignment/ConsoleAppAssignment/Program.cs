using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to the Loop Practice App!");

            // -----------------------------
            // DO WHILE LOOP
            // -----------------------------

            // Create a counter variable
            int count = 1;

            // The do block always runs at least once
            do
            {
                Console.WriteLine("Do While Loop: Count = " + count);

                // Increase the counter
                count++;

            } while (count <= 5);

            // -----------------------------
            // WHILE LOOP
            // -----------------------------

            // Create another counter variable
            int number = 1;

            // Continue looping while the condition is true
            while (number <= 3)
            {
                Console.WriteLine("While Loop: Number = " + number);

                // Increase the number
                number++;
            }

            // -----------------------------
            // IF / ELSE
            // -----------------------------

            // Ask the user for their age
            Console.WriteLine("Please enter your age:");

            // Read and convert the user's input
            int age = Convert.ToInt32(Console.ReadLine());

            // Check if the user is an adult
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are under 18.");
            }

            // -----------------------------
            // TERNARY OPERATOR
            // -----------------------------

            // Create a message using a ternary operator
            string result = age >= 18 ? "Adult" : "Minor";

            // Display the result
            Console.WriteLine("Ternary result: " + result);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}