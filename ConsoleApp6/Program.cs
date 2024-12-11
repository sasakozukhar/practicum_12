using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static int Kop(int r, int k)
        {
            return r * 100 + k;
        }
        static void Main(string[] args)
        {
            int rubles1 = 5;
            int kopecks1 = 24;
            int totalKopecks1 = Kop(rubles1, kopecks1);
            Console.WriteLine($"Количество копеек в 5 руб. 24 коп.: {totalKopecks1}");

        }
    }
}
