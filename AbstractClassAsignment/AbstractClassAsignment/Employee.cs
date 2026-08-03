using AbstractClassAsignment;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAsignment
{
    // Employee inherits all common properties from the Person class.
    public class Employee : Person
    {
        // Stores an identification number for the employee.
        public int EmployeeNumber { get; set; }

        // Provides the Employee class's own implementation of SayName.
        public override void SayName()
        {
            Console.WriteLine($"Employee name: {FirstName} {LastName}");
        }
    }
}