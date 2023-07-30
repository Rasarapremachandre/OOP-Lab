using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Quiz2._2
{
    class FindValues
    {
        public double findArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public double findCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            FindValues obj = new FindValues();


            Console.WriteLine("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());


            double area = obj.findArea(radius);


            double circumference = obj.findCircumference(radius);


            Console.WriteLine("The area of the circle is {0}", area);
            Console.WriteLine("The circumference of the circle is {0}", circumference);
        }
    }
}  

