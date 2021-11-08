using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "iç giyim", "Takı saat", "Bilgisayar, Ofis ve Güvenlik", "Oyuncak , Çocuk ve Bebek" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
