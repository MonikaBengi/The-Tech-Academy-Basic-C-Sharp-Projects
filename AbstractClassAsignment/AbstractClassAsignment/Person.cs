using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAsignment
{
    // This abstract class stores information that is common to every person.
    public abstract class Person
    {
        // Stores the person's first name.
        public string FirstName { get; set; }

        // Stores the person's surname.
        public string LastName { get; set; }

        // Every class that inherits from Person must provide its own version
        // of the SayName method.
        public abstract void SayName();
    }
}