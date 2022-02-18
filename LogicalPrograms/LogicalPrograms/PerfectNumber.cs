using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public void ChcekPerfectNumber()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine("entered number is perfect number");
            }
            else
            {
                Console.WriteLine("entered number is not perfect");
            }
        }
    }
}
