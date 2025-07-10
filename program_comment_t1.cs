using System;// Importing System namespace for input/output functions
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace tutorial_1  // Declaring namespace
{
    class Pprogram_comment_t1  // Declaring class name
    {
        static void Main(string[] args)  // Main method: Entry point of the program
        {
            int n, fact = 1;  // Declaring integer variables 'n' and 'fact' (initializing fact = 1)

            Console.WriteLine("Enter Number : ");  // Prompting the user 

            string str = Console.ReadLine();  // Reading user input 

            n = Convert.ToInt32(str);  // Converting string input to integer and storing in 'n'

            for (int i = 1; i <= n; i++)  // Loop from 1 to n to calculate factorial
            {
                fact = fact * i;  // Multiply fact with current value of i
            }

            Console.WriteLine("Factorial : {0}", fact);  // Displayingresult

            Console.Read();  // Waits for user to press a key before closing the console
        }
    }
}

