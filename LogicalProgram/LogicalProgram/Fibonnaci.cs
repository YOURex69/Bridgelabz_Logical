using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgram
{
    public class Fibonnaci
    {
        public void getFibonnaci()
        {
            Console.WriteLine("Enter number: ");
            int userInput = int.Parse(Console.ReadLine());
            int[] arr = new int[userInput + 1];

            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i <= userInput; i++)
            {
                arr[i] = arr[i-1] + arr[i - 2];
            }
            Console.WriteLine("The  Fibonnaci series is :");
            for (int i = 0; i <= userInput; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
