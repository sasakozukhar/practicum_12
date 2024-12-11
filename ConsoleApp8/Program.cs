using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static int FindMinimum(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите три целых числа:");
            int minimum = FindMinimum(num1, num2, num3);
            Console.WriteLine($"Минимальное число: {minimum}");
        }
    }
}
