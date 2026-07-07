using System;

namespace MethodClassAssignment
{
    public class NumberMethods
    {
        // This method takes two integer numbers.
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Multiply the first number by 4.
            int result = firstNumber * 4;

            // Display the result of the math operation.
            Console.WriteLine("First number multiplied by 4 is: " + result);

            // Display the second number.
            Console.WriteLine("Second number is: " + secondNumber);
        }
    }
}