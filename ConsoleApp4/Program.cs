using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static int Centimeters(int m, int c)
        {
            return m * 100 + c;
        }
        static void Main(string[] args)
        {
            int meters = 2;
            int centimeters = 30;
            int totalCentimeters = Centimeters(meters, centimeters);
            Console.WriteLine($"Количество сантиметров: {totalCentimeters}");
            Console.ReadKey();
        }
    }
}
