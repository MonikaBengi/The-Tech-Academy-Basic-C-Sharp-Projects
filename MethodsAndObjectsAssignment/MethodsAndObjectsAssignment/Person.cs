using System;

namespace MethodsAndObjectsAssignment
{
    // This class stores the basic information about a person.
    public class Person
    {
        // Stores the person's first name.
        public string FirstName { get; set; }

        // Stores the person's last name.
        public string LastName { get; set; }

        // Displays the person's full name in the console.
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}