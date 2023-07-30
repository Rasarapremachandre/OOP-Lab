using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a first number: ");
                string firstNumberStr = Console.ReadLine();
                int firstNumber = Convert.ToInt32(firstNumberStr);

                Console.WriteLine("Enter a second number: ");
                string secondNumberStr = Console.ReadLine();
                int secondNumber = Convert.ToInt32(secondNumberStr);

                int sum = firstNumber + secondNumber;
                int difference = firstNumber - secondNumber;
                int product = firstNumber * secondNumber;
                float quotient = firstNumber / secondNumber;

                Console.WriteLine("The sum of a two numbers is: " + sum);
                Console.WriteLine("The difference of the a numbers is: " + difference);
                Console.WriteLine("The product of the a numbers is: " + product);
                Console.WriteLine("The quotient of the a numbers is: " + quotient);
            }
    }
}
