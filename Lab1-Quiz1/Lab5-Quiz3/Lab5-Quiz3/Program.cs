using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Quiz3
{
    class CalculateValues
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            CalculateValues calculateValues = new CalculateValues();

            int choice = 0;
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter two numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("The answer is: " + calculateValues.Addition(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("The answer is: " + calculateValues.Subtraction(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("The answer is: " + calculateValues.Multiplication(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("The answer is: " + calculateValues.Division(num1, num2));
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
