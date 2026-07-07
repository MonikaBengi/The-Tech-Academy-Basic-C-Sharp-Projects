using System;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object from the NumberMethods class.
            NumberMethods methods = new NumberMethods();

            // Ask the user for a number.
            Console.WriteLine("Please enter a number:");

            // Read the number.
            int number = Convert.ToInt32(Console.ReadLine());

            // Call the first method.
            Console.WriteLine("Multiply by 2: " + methods.Multiply(number));

            // Call the second method.
            Console.WriteLine("Add 20: " + methods.AddTwenty(number));

            // Call the third method.
            Console.WriteLine("Subtract 5: " + methods.SubtractFive(number));

            Console.ReadLine();
        }
    }
}
