using System;

namespace ClassMethodAssignment
{
    public class NumberTools
    {
        // This void method takes an integer and displays the number divided by 2.
        public void DivideNumber(int number)
        {
            // Divide the number by 2.
            int answer = number / 2;

            // Display the answer to the screen.
            Console.WriteLine("Your number divided by 2 is: " + answer);
        }

        // This method uses an output parameter.
        public void GetSquare(int number, out int square)
        {
            // Multiply the number by itself.
            square = number * number;
        }

        // This is an overloaded method with an integer parameter.
        public int AddTen(int number)
        {
            // Add 10 to the number.
            return number + 10;
        }

        // This is an overloaded method with two integer parameters.
        public int AddTen(int number, int extraNumber)
        {
            // Add 10 and the extra number.
            return number + 10 + extraNumber;
        }
    }
}