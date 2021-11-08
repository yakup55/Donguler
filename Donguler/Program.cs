using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici tetiştirme kampı";
            string kurs2 = "program geliştirici tetiştirme kampı";
            string kurs3 = "java";


            string[] kurslar = new string[] {"java", "yazılım geliştirici tetiştirme kampı" , "program geliştirici tetiştirme kampı","python","C#" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }




            Console.WriteLine("sayfa sonu");
        }
    }
}
