using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedByIntApplication
{
    public static class DivisonLogic

    {
        public static int AcceptNumber()
        {
            int i = 0;
            Console.WriteLine("Enter valid number:");
            string? input = Console.ReadLine();
            int.TryParse(input, out i);
            return i;
        }
        public static string  printResult(int i)
        {
            string output=i.ToString();
            if (i == 0 || (i % 3 == 0 && i % 5 == 0))
            {
                //Console.WriteLine("FizzBuzz");
                output = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                //Console.WriteLine("Fizz");
                output = "Fizz";
            }
            else if (i % 5 == 0)
            {
                //Console.WriteLine("Buzz");
                output = "Buzz";
            } 
            return output;
        }
    }
}
