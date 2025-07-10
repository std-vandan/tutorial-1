using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_1
{
    class amstrong
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int originalNum = num;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum += digit * digit * digit;
                num = num / 10;
            }

            if (sum == originalNum)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not an Armstrong Number");

            Console.ReadLine();
        }
    }
}
