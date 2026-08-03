using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAsignment
{
        // Defines a rule for classes that can perform a quitting action.
        public interface IQuittable
        {
            // Any class that implements this interface must provide a Quit method.
            void Quit();
        }
    }
