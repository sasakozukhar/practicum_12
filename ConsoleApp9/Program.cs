using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения a и b:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int z = Min(2 * a, b + a) + Min(2 * a - b, b);
            Console.WriteLine($"Результат z: {z}");
        }
    }
}
