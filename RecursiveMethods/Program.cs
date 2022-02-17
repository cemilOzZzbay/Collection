using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamFor = ToplaFor(1, 5);
            int toplamRecursive = ToplaRecursive(1, 5);
            Console.WriteLine(toplamFor);
            Console.WriteLine(toplamRecursive);
            Console.ReadLine();
        }
        static int ToplaFor(int baslangic, int bitis, int artis = 1)
        {
            int toplam = 0;
            for (int i = baslangic; i <= bitis; i = i + artis)
            {
                toplam = toplam + i;
            }
            return toplam;
        }
        static int ToplaRecursive(int baslangic, int bitis, int artis = 1, int toplam = 0)
        {
            if (baslangic > bitis)
                return toplam;
            toplam = toplam + baslangic;
            baslangic = baslangic + artis;
            toplam = ToplaRecursive(baslangic, bitis, artis, toplam);
            return toplam;
        }
    }
}
