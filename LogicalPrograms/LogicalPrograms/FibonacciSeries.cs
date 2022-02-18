using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        public void PrintFibonacciSeries()
        {
            int firstNUm = 0, secondNUm = 1, thirdNum;
            Console.WriteLine("enter number of elements");
            int element = Convert.ToInt32(Console.ReadLine());
            Console.Write(firstNUm + " " + secondNUm + " ");
            for (int i = 2; i <= element; i++)
            {
                thirdNum = firstNUm + secondNUm;
                Console.Write(thirdNum + " ");
                firstNUm = secondNUm;
                secondNUm = thirdNum;
            }
        }
    }
}
