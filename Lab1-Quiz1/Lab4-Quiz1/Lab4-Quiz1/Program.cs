using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Quiz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues obj = new ConvertValues();

            obj.kilometerToMeter();
        }
    }

    class ConvertValues
    {
        public void kilometerToMeter()
        {

            double meter = 1000;

            Console.WriteLine("1 kilometer = {0} meters", meter);
        }
    
    }
}
