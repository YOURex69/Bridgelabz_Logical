using System;

namespace LogicalProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
           Label:Console.WriteLine("Enter choices(1-6) \n1.Fibonnaci\n2.Perfect Number\n3.PrimeNumber\n4.ReverseANumber\n5.CouponNumber\n6.SimulateAStopWatch");
            int userChoice = int.Parse(Console.ReadLine());
      

            switch (userChoice)
            {
                case 1:
                    Fibonnaci Obj1 = new Fibonnaci();
                    Obj1.getFibonnaci();
                    break;
                case 2:
                    PerfectNumbers Obj2 = new PerfectNumbers();
                    Obj2.getPerfect();
                    break;
                case 3:
                    PrimeNumbers Obj3 = new PrimeNumbers();
                    Obj3.isPrime();
                    break;
                case 4:
                    ReverseANumber Obj4 = new ReverseANumber();
                    Obj4.doReverse();
                    break;
                case 5:
                    CouponNumber Obj5 = new CouponNumber();
                    Obj5.getCoupon();
                    break;
                case 6:
                    SimulateStopwatch Obj6 =new SimulateStopwatch();
                    Obj6.startStopWatch();
                    break;
            
                default:
                    Console.WriteLine("Enter number between 1-6");
                    break;
            }
            Console.WriteLine("Continue...y/n");
            if (Console.ReadKey().KeyChar.ToString() == "y")
            {
                goto Label;
            }
            Console.ReadKey();

        }
    }
}
