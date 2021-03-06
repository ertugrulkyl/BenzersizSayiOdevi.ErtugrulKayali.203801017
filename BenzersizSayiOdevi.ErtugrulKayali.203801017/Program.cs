using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzersizSayiOdevi.ErtugrulKayali._203801017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç Adet Sayı Üretmek İstersiniz? :");
            int adet = int.Parse(Console.ReadLine());
            int[] sayilar = new int[adet];

            Random rnd = new Random();
            bool esitmi = true;

            for (int i = 0; i < sayilar.Length; i++)
            {
                esitmi = true;
                while (esitmi)
                {
                    int sayi = rnd.Next(1, 100);
                    bool esitOlanVarMi = false;
                    for (int j = 0; j < sayilar.Length; j++)
                    {
                        if (sayilar[j] == sayi)
                        {
                            esitOlanVarMi = true;
                            break;
                        }
                    }
                    if (!esitOlanVarMi)
                    {
                        sayilar[i] = sayi;
                        esitmi = false;
                    }
                }
            }
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"{sayilar[i]}-");
            }

            Console.ReadKey();
        }
    }
}
