using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new Employee object and gives values to its properties.
            Employee studentEmployee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 101
            };

            // Calls the SayName method inherited from the Person class.
            studentEmployee.SayName();

            // Keeps the console window open until the user presses Enter.
            Console.ReadLine();
        }
    }
}