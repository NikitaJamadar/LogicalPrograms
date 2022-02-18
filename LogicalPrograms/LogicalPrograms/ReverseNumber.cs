using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public void FindReverseNumber()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem, reverse = 0;
            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse of number is:" + reverse);
        }
    }
}
