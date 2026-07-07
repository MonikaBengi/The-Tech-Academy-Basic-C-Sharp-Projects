using System;

namespace MethodAssignment
{
    public class NumberCalculator
    {
        // This method takes two integers.
        // The second integer is optional and has a default value of 10.
        public int AddNumbers(int firstNumber, int secondNumber = 10)
        {
            // Add the two numbers together.
            int result = firstNumber + secondNumber;

            // Return the final answer.
            return result;
        }
    }
}