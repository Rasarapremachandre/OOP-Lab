using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Quiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a second number:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;

            Console.WriteLine("The sum of " + number1 + " and " + number2 + " is: " + sum);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
