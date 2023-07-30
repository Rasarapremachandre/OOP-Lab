using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Quiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your batch: ");
            string batch = Console.ReadLine();

            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your batch is: " + batch);

            Console.ReadLine();
        }
    }
}
