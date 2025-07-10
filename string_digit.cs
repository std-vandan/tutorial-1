using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_1
{
    class string_digit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Mobile Number: ");
            string mobile = Console.ReadLine();

            string masked = mobile.Substring(0, mobile.Length - 5) + "XXXXX";

            Console.WriteLine("Masked Mobile Number: " + masked);
            Console.ReadLine();
        }
    }
}
