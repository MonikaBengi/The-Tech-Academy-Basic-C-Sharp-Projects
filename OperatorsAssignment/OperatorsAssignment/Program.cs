using System;

namespace OperatorsAssignment
{
    // Contains the main entry point of the console application.
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object.
            Employee employee1 = new Employee();

            // Assign values to the first employee's properties.
            employee1.Id = 1;
            employee1.FirstName = "Jesse";
            employee1.LastName = "Johnson";

            // Create the second Employee object.
            Employee employee2 = new Employee();

            // Assign values to the second employee's properties.
            employee2.Id = 1;
            employee2.FirstName = "Adam";
            employee2.LastName = "Smith";

            // Compare the two employees using the overloaded == operator.
            if (employee1 == employee2)
            {
                // This runs if the employees have the same ID.
                Console.WriteLine("The employees have the same ID.");
            }
            else
            {
                // This runs if the employees have different IDs.
                Console.WriteLine("The employees have different IDs.");
            }

            // Keep the console window open until the user presses Enter.
            Console.ReadLine();
        }
    }
}