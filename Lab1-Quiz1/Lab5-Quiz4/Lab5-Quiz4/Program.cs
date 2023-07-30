using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Quiz4
{
    public class MyClass
    {
        private void SayHello()
        {
            Console.WriteLine("Hello, world!");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
           
            var myClass = new MyClass();
           
        }
    }
    public class MyClass
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, world!");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var myClass = new MyClass();
            
            myClass.SayHello();
        }
    }

}
