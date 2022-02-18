using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Fibonacci Series 2.PerfectNumber 3.PrimeNumber 4.Reverse number 5.coupon number 6.stopwatch");
            Console.WriteLine("enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.PrintFibonacciSeries();
                    break;

                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.ChcekPerfectNumber();
                    break;

                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.CheckPrimeNumber();
                    break;

                case 4:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.FindReverseNumber();
                    break;

                case 5:
                    CouponNumbers couponNumbers = new CouponNumbers();
                    couponNumbers.couponNo();
                    break;


            }
        }
    }
}
