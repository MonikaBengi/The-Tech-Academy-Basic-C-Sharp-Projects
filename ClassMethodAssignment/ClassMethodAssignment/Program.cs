using System;
using System.Runtime.Remoting.Messaging;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object from the NumberTools class.
            NumberTools tools = new NumberTools();

            // Ask the user to enter a number.
            Console.WriteLine("Please enter a number:");

            // Convert the user's input into an integer.
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Call the void method and pass in the user's number.
            tools.DivideNumber(userNumber);

            // Create a variable for the output parameter.
            int squareResult;

            // Call the method with the output parameter.
            tools.GetSquare(userNumber, out squareResult);

            // Display the output parameter result.
            Console.WriteLine("Your number squared is: " + squareResult);

            // Call the overloaded method with one parameter.
            int firstResult = tools.AddTen(userNumber);

            // Display the first overloaded method result.
            Console.WriteLine("Your number plus 10 is: " + firstResult);

            // Call the overloaded method with two parameters.
            int secondResult = tools.AddTen(userNumber, 5);

            // Display the second overloaded method result.
            Console.WriteLine("Your number plus 10 and 5 is: " + secondResult);

            // Call the method from the static class.
            Helper.ShowMessage();

            // Keep the console window open.
            Console.ReadLine();
        }
    }
}