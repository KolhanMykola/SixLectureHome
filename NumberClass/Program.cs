using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberLibrary;

namespace NumberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();
            Console.WriteLine("Input number to check if it is prime:");
            int input = Convert.ToInt32(Console.ReadLine());
            if (number.IsPrime(input))
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }

            Console.WriteLine("Input number to calculate Fibonacci:");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number.Fibonacci(input));

            Console.ReadLine();
        }
    }
}
