using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    public class PerfectNumbers
    {
        public void getPerfect()
        {
            Console.WriteLine("Enter number: ");
            int userInput = int.Parse(Console.ReadLine());
            int sum = 0;
            int i = 1;
            while (i < userInput)
            {
                if (userInput % i == 0)
                {
                    sum = sum + i;
                }
                i++;
            }

            if(sum==userInput)
            {
                Console.WriteLine(userInput+" is a Perfect Number");
            }
            else
            {
                Console.WriteLine(userInput + " is not a Perfect Number");
            }
        }
    }
}
