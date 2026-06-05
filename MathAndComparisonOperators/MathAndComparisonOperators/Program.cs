using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print program title
            Console.WriteLine("Anonymous Income Comparison Program");

            // Get Person 1 information
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            string hours1 = Console.ReadLine();

            // Calculate annual salary for Person 1
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;

            // Get Person 2 information
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine();

            // Calculate annual salary for Person 2
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;

            // Display salaries
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);

            // Compare salaries
            Console.WriteLine("Person 1 makes more money than Person 2");

            bool isMore = salary1 > salary2;

            Console.WriteLine(isMore);

            // Keep console window open
            Console.ReadLine();
        }
    }
}