using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static int Centimeters(int m, int c)
        {
            return m * 100 + c;
        }
        static void Main(string[] args)
        {
            int meters = 15;
            int centimeters = 27;
            int totalCentimeters = Centimeters(meters, centimeters);
            Console.ReadKey(); 
        }
    }
}
