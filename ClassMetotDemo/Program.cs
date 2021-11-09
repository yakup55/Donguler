using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "yakup";
            string soyadi = "yıldırım";
            int yas = 18;
            string Tc = "1234567890";

            Cutomer cutomer = new Cutomer();
            cutomer.adi = "yakup";
            cutomer.soyadi = "yıldırım";
            cutomer.Tc = "12345678";
            cutomer.Yas = 18;


            Cutomer cutomer2 = new Cutomer();
            cutomer2.adi= "yakup";
            cutomer2.soyadi = "yıldırım";
            cutomer2.Tc = "12345678";
            cutomer2.Yas = 18;

            Cutomer[] cutomers = new[] { cutomer }; 

            foreach (Cutomer cutomer1  in cutomers)
            {
                Console.WriteLine(cutomer1.adi+ "eklendi");
                Console.WriteLine(cutomer1.soyadi+ "eklendi");
                Console.WriteLine(cutomer1.Yas+ "eklendi");
                Console.WriteLine(cutomer1.Tc+ "eklendi");


                Console.WriteLine("-------------------------------------");

                Console.WriteLine(cutomer2.adi +  "silindi");
                Console.WriteLine(cutomer2.soyadi +"silindi");
                Console.WriteLine(cutomer2.Yas+ "silindi");
                Console.WriteLine(cutomer2.Tc+ "silindi");

            }
        }


    }
}
