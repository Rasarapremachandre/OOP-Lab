using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Quiz5
{
     class ArrayOperations
        {
            private int[] arr;

            public ArrayOperations(int size)
            {
                arr = new int[size];
            }

            public void InputValues()
            {
                Console.WriteLine($"Enter {arr.Length} integer values:");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }

            public int FindMinimum()
            {
                int min = arr[0];
                foreach (int value in arr)
                {
                    if (value < min)
                    {
                        min = value;
                    }
                }
                return min;
            }

            public int FindMaximum()
            {
                int max = arr[0];
                foreach (int value in arr)
                {
                    if (value > max)
                    {
                        max = value;
                    }
                }
                return max;
            }

            public double FindAverage()
            {
                int sum = 0;
                foreach (int value in arr)
                {
                    sum += value;
                }
                return (double)sum / arr.Length;
            }

            public void ReverseOrder()
            {
                int start = 0;
                int end = arr.Length - 1;

                while (start < end)
                {
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    start++;
                    end--;
                }
            }
        }

        class Program
        {
        private static IEnumerable<int> arrayOperations;

        static void Main()
            {
                int size = 10;
                ArrayOperations arrayOperations = new ArrayOperations(size);

                arrayOperations.InputValues();

                int min = arrayOperations.FindMinimum();
                int max = arrayOperations.FindMaximum();
                double avg = arrayOperations.FindAverage();

                Console.WriteLine("Minimum value: " + min);
                Console.WriteLine("Maximum value: " + max);
                Console.WriteLine("Average value: " + avg);

                Console.WriteLine("Original array:");
                PrintArray(arrayOperations);

                arrayOperations.ReverseOrder();

                Console.WriteLine("Reversed array:");
                PrintArray(arrayOperations);
            }

        private static void PrintArray(ArrayOperations ArrayOperations)
            {
            foreach (int value in  arrayOperations) 
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
        }

    }



