using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    public class PrimeNumbers
    {
        public void isPrime()
        {
            Console.WriteLine("Enter number: ");
            int userInput = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=2;i*i<userInput;i++)
            {
                if(userInput%i==0)
                {
                    count++;
                }
            }
            if(count==0)
            {
                Console.WriteLine(userInput + " is a Prime Number");
            }
            else
            {
                Console.WriteLine(userInput + " is not a Prime Number");
            }

        }
    }
}
