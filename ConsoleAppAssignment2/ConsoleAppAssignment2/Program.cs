using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            // Assignment Part 1
            //            // Create a one-dimensional array of strings.
            //            string[] sentences = { "Hello ", "Welcome ", "Good luck " };

            //            // Ask the user to input some text.
            //            Console.WriteLine("Please enter your name:");
            //            string userText = Console.ReadLine();

            //            // Loop through each string and add the user's text to the end.
            //            for (int i = 0; i < sentences.Length; i++)
            //            {
            //                sentences[i] = sentences[i] + userText;
            //            }

            //            // Second loop prints each string in the array.
            //            foreach (string sentence in sentences)
            //            {
            //                Console.WriteLine(sentence);
            //            }



            // Assignment Part 2
            // Infinite loop example (fixed)

            // The infinite loop was fixed by adding a counter.
            // The loop now stops after 5 iterations.

            //int counter = 0;

            //while (counter < 5)
            //{
            //    Console.WriteLine("Loop number: " + counter);
            //    counter++;
            //}


            //// Assignment Part 3

            //// Loop using the < operator
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Less than (<): " + i);
            //}

            //Console.WriteLine();

            //// Loop using the <= operator
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("Less than or equal to (<=): " + i);
            //}


            //            // Assignment Part 4

            //            List<string> fruits = new List<string>()
            //{
            //    "Apple",
            //    "Banana",
            //    "Orange",
            //    "Grapes",
            //    "Strawberry"
            //};

            //            Console.WriteLine("Enter a fruit to search for:");
            //            string userInput = Console.ReadLine();

            //            bool found = false;

            //            for (int i = 0; i < fruits.Count; i++)
            //            {
            //                if (fruits[i].Equals(userInput, StringComparison.OrdinalIgnoreCase))
            //                {
            //                    Console.WriteLine("Item found at index: " + i);
            //                    found = true;
            //                    break; // Stop the loop once a match has been found.
            //                }
            //            }

            //            if (!found)
            //            {
            //                Console.WriteLine("The item you entered is not on the list.");
            //            }

            //            // Assignment Part 5

            //            List<string> fruits = new List<string>()
            //{
            //    "Apple",
            //    "Banana",
            //    "Orange",
            //    "Apple",
            //    "Grapes",
            //    "Banana"
            //};

            //            Console.WriteLine("Enter a fruit to search for:");
            //            string userInput = Console.ReadLine();

            //            bool found = false;

            //            for (int i = 0; i < fruits.Count; i++)
            //            {
            //                if (fruits[i].Equals(userInput, StringComparison.OrdinalIgnoreCase))
            //                {
            //                    Console.WriteLine("Item found at index: " + i);
            //                    found = true;
            //                }
            //            }

            //            if (!found)
            //            {
            //                Console.WriteLine("The item you entered is not on the list.");
            //            }


            // Assignment Part 6

            // Create a list of strings with duplicate values.
            List<string> names = new List<string>()
{
    "John",
    "Emma",
    "David",
    "Emma",
    "Sarah",
    "John"
};

            // Create a second list to keep track of items that have already appeared.
            List<string> checkedNames = new List<string>();

            Console.WriteLine("Names in the list:");

            foreach (string name in names)
            {
                if (checkedNames.Contains(name))
                {
                    Console.WriteLine(name + " - This item is a duplicate.");
                }
                else
                {
                    Console.WriteLine(name + " - This item is unique.");
                }

                // Add the current item to the checked list.
                checkedNames.Add(name);
            }

            Console.ReadLine();
        }
    }
}