using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static int Kop(int r, int k)
        {
            return r * 100 + k;
        }
        static void Main(string[] args)
        {
            int rubles2 = 15;
            int kopecks2 = 7;
            int totalKopecks2 = Kop(rubles2, kopecks2);
            Console.WriteLine($"Количество копеек в 15 руб. 7 коп.: {totalKopecks2}");

        }
    }
}
