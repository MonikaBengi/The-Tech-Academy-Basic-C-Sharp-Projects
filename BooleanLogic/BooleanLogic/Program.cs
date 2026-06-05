using System;

namespace ThemeParkCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the program title
            Console.WriteLine("Theme Park Ride Check");

            // Ask the user for their age
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask if the user is with an adult
            Console.WriteLine("Are you with an adult? Please enter true or false.");
            bool withAdult = Convert.ToBoolean(Console.ReadLine());

            // Ask the user for their height in centimeters
            Console.WriteLine("What is your height in centimeters?");
            int height = Convert.ToInt32(Console.ReadLine());

            // Check if the user can ride the roller coaster
            bool canRide = age > 15 && withAdult && height >= 120;

            // Display the result
            Console.WriteLine("Can ride the roller coaster?");
            Console.WriteLine(canRide);

            // Keep the console window open
            Console.ReadLine();
        }
    }
}