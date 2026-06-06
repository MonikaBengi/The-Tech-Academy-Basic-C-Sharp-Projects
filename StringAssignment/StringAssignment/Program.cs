using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create three separate strings
            string firstWord = "I";
            string secondWord = "love";
            string thirdWord = "coding!";

            // Concatenate the three strings into one sentence
            string sentence = firstWord + " " + secondWord + " " + thirdWord;

            // Display the concatenated sentence
            Console.WriteLine(sentence);

            // Convert the sentence to uppercase
            string upperSentence = sentence.ToUpper();

            // Display the uppercase sentence
            Console.WriteLine(upperSentence);

            // Display the number of characters in the sentence
            Console.WriteLine("Sentence length: " + sentence.Length);

            // Create a StringBuilder object
            StringBuilder paragraph = new StringBuilder();

            // Add the first sentence
            paragraph.Append("I enjoy learning C#. ");

            // Add the second sentence
            paragraph.Append("Every lesson teaches me something new. ");

            // Add the third sentence
            paragraph.Append("Practice helps me become a better developer.");

            // Display the completed paragraph
            Console.WriteLine(paragraph.ToString());

            // Display a simple goodbye message
            Console.WriteLine("Thank you for reading!");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}