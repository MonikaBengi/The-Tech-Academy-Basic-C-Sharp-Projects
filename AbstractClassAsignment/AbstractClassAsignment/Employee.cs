using AbstractClassAsignment;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAsignment
{
        // Employee inherits common person details and implements IQuittable.
        public class Employee : Person, IQuittable
        {
            // Stores an identification number for the employee.
            public int EmployeeNumber { get; set; }

            // Displays the employee's full name.
            public override void SayName()
            {
                Console.WriteLine($"Employee name: {FirstName} {LastName}");
            }

            // Provides the quitting behaviour required by IQuittable.
            public void Quit()
            {
                Console.WriteLine($"{FirstName} {LastName} has left the company.");
            }
        }
    }