using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Quiz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter a second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            Console.WriteLine("The sum of the two numbers is: " + sum);
            Console.ReadLine();
        }
    }
}
