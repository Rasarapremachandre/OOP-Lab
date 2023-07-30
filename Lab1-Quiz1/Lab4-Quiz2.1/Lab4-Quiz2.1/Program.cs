using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Quiz2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, area, circumference;

            Console.WriteLine("Enter the radius of the circle: ");
            radius = double.Parse(Console.ReadLine());


            area = Math.PI * radius * radius;
            circumference = 2 * Math.PI * radius;

            Console.WriteLine("The area of the circle is {0}", area);
            Console.WriteLine("The circumference of the circle is {0}", circumference);
        }
    
}
    }

