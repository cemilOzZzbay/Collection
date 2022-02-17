using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exit = "0";
            Console.WriteLine("Pozitif sayılar girin (çıkış: 0)");
            string input;
            int number;
            List<int> numbers = new List<int>();
            input = Console.ReadLine();
            while (input != "0")
            {
                number = Convert.ToInt32(input);
                if (number > 0)
                    numbers.Add(number);
                input = Console.ReadLine();
            }
            if (numbers.Count > 0)
            {
                Console.WriteLine("Girilen sayılar: ");
                //for(int i=0; i<numbers.Count; i++)
                //{
                //    Console.WriteLine(numbers[i]);
                //}
                foreach (int n in numbers)
                {
                    Console.WriteLine(n);
                }
                List<int> reversedNumbers = numbers.ToList();
                reversedNumbers.Reverse();
                Console.WriteLine("Tersine sayılar: ");
                foreach (var n in reversedNumbers)
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine("Girilen sayıların toplamı: " + numbers.Sum());
                Console.WriteLine("Girilen sayıların ortalaması: " + numbers.Average());
                Console.WriteLine("Girilen sayıların maksimumu: " + numbers.Max());
                Console.WriteLine("Girilen sayıların minimumu: " + numbers.Min());
                Console.Write("Aranacak sayı: ");
                int aranacak = Convert.ToInt32(Console.ReadLine());

                //bool bulundu = false; // flag
                //for(int i=0; i<numbers.Count && !bulundu; i++)
                //{
                //    if (numbers[i] == aranacak)
                //    {
                //        bulundu = true;
                //        //break;
                //    }
                //}
                //if (bulundu)
                //    Console.WriteLine(aranacak + " liste içinde bulundu");
                //else
                //    Console.WriteLine(aranacak + " liste içinde bulunamadı");
                int sonuc = numbers.FirstOrDefault(n => n == aranacak);
                if (sonuc == 0)
                    Console.WriteLine(aranacak + " liste içinde bulunamadı");
                else
                    Console.WriteLine(aranacak + " liste içinde bulundu");
            }
            Console.ReadLine();
        }
    }
}
