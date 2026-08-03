using AbstractClassAsignment;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAsignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates an Employee object and assigns the required name values.
            Employee newEmployee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                EmployeeNumber = 1001
            };

            // Calls the version of SayName implemented by the Employee class.
            newEmployee.SayName();

            // Keeps the console window open until the user presses Enter.
            Console.ReadLine();
        }
    }
}