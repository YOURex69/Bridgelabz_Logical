using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    public class ReverseANumber
    {
        public void doReverse()
        {
            Console.WriteLine("Enter number: ");
            int userInput = int.Parse(Console.ReadLine());

            int reversedNumber = 0;
            while(userInput!=0)
            {
                int lastDigit = userInput % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                userInput = userInput / 10;
            }
            Console.WriteLine("Reversed Number is " + reversedNumber);
        }
    }
}
