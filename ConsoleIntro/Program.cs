using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.kursAdı = "c#";
            kurs1.Egitmen = "yakup yıldırım";
            kurs1.IzlenmeOranı = "78";



            kurs kurs2 = new kurs();
            kurs2.kursAdı = "java";
            kurs2.Egitmen = "yakup yıldırım";
            kurs2.IzlenmeOranı = "98";


            kurs kurs3 = new kurs();
            kurs3.kursAdı = "python";
            kurs3.Egitmen = "yakup yıldırım";
            kurs3.IzlenmeOranı = "88";

            


            

        }
    }
    class kurs
    {
        public String kursAdı { get; set; }

        public String Egitmen  { get; set; }

        public String IzlenmeOranı { get; set; }
    }

}
