﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Quiz6
{
    internal class Program
    {
        public void UserInput(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
                array[i + 1] = 0;
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size:");
            int size = Convert.ToInt32(Console.ReadLine());

            CalculateValues CalculateValues = new CalculateValues();

            CalculateValues.UserInput(size);
        }
    }
}
