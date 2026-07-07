using System;

namespace MainMethodAssignment
{
    public class Calculator
    {
        // This method receives an integer and multiplies it by 5.
        public int Calculate(int number)
        {
            return number * 5;
        }

        // This method receives a decimal number, converts it to an integer and subtracts 4.
        public int Calculate(decimal number)
        {
            int wholeNumber = Convert.ToInt32(number);
            return wholeNumber - 4;
        }

        // This method receives a string, converts it to an integer and adds 15.
        public int Calculate(string number)
        {
            int wholeNumber = Convert.ToInt32(number);
            return wholeNumber + 15;
        }
    }
}