using System;
using System.Collections.Generic;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of strings
            string[] animals = { "Dog", "Cat", "Rabbit", "Tiger", "Lion", "Horse", "Panda", "Fox", "Bear", "Wolf" };

            // Ask the user for an index
            Console.WriteLine("Select a number between 0 and 9 to see an animal:");

            // Read the user's input
            int animalSelect = Convert.ToInt32(Console.ReadLine());

            // Variable used to keep the loop running until a valid index is entered
            bool validAnimal = false;

            // Keep asking until the user enters a valid number
            while (!validAnimal)
            {
                try
                {
                    // Display the selected animal
                    Console.WriteLine("Your animal is: " + animals[animalSelect]);

                    // Exit the loop
                    validAnimal = true;
                }
                catch
                {
                    // Display an error message if the index does not exist
                    Console.WriteLine("Invalid selection. Please choose a number between 0 and 9.");

                    // Ask again
                    animalSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Create a list of strings
            List<string> hobbies = new List<string>()
            {
                "Reading",
                "Gaming",
                "Swimming",
                "Cooking",
                "Drawing",
                "Running",
                "Coding",
                "Music",
                "Travel",
                "Photography"
            };

            // Ask the user for another index
            Console.WriteLine("\nSelect another number between 0 and 9:");

            // Read the user's input
            int hobbySelect = Convert.ToInt32(Console.ReadLine());

            // Variable used to validate the input
            bool validHobby = false;

            // Loop until the user enters a valid index
            while (!validHobby)
            {
                try
                {
                    // Display the selected hobby
                    Console.WriteLine("Your hobby is: " + hobbies[hobbySelect]);

                    // Exit the loop
                    validHobby = true;
                }
                catch
                {
                    // Display an error message
                    Console.WriteLine("Invalid selection. Please choose a number between 0 and 9.");

                    // Ask again
                    hobbySelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Create an array of integers
            int[] luckyNumbers = { 5, 12, 18, 24, 31, 42, 56, 67, 78, 99 };

            // Ask the user for one more index
            Console.WriteLine("\nSelect one more number between 0 and 9:");

            // Read the user's input
            int numberSelect = Convert.ToInt32(Console.ReadLine());

            // Variable used to validate the input
            bool validNumber = false;

            // Keep asking until the user enters a valid index
            while (!validNumber)
            {
                try
                {
                    // Display the selected number
                    Console.WriteLine("Your lucky number is: " + luckyNumbers[numberSelect]);

                    // Exit the loop
                    validNumber = true;
                }
                catch
                {
                    // Display an error message
                    Console.WriteLine("Invalid selection. Please choose a number between 0 and 9.");

                    // Ask again
                    numberSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Extra feature
            Console.WriteLine("\nThanks for using my program!");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}