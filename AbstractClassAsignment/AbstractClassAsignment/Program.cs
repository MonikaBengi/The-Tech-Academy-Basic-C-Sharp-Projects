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
                // Creates an Employee object but stores it in an IQuittable variable.
                IQuittable quittableEmployee = new Employee
                {
                    FirstName = "Sample",
                    LastName = "Student",
                    EmployeeNumber = 1001
                };

                // Calls the Quit method through the interface reference.
                quittableEmployee.Quit();

                // Keeps the console window open.
                Console.ReadLine();
            }
        }
    }