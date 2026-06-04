using System;

namespace StudentReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print school name
            Console.WriteLine("Academy of Learning Career College");

            // Print report title
            Console.WriteLine("Student Daily Report");

            // Ask student's name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // Ask course name
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Ask page number
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // Ask if help is needed
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            // Ask about positive experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            // Ask for additional feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Ask study hours
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());

            // End message
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");

            Console.ReadLine();
        }
    }
}
