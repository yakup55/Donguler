using System;

namespace Metotlar
{
    class 
        
     Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "amasya elması";

            
            string[] meyveler = new string[] { };

            Urün urun1= new Urün();
            urun1.Adi = "elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "amasya elması";

            Urün urun2 = new Urün();
            urun2.Adi = "karpuz";
            urun2.Fiyatı = 100;
            urun2.Aciklama = "hakiki karpuz";

            Urün[] urunler = new Urün[] { urun1, urun2 };




            foreach (Urün urün  in urunler)
            {
                Console.WriteLine(urun1.Adi);
                Console.WriteLine(urun1.Fiyatı);
                Console.WriteLine(urun1.Aciklama);



                Console.WriteLine(urun2.Adi);
                Console.WriteLine(urun2.Fiyatı);
                Console.WriteLine(urun2.Aciklama);





            }
            Console.WriteLine("------------------metotlar----------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "sarı armut", 12,  10);
            sepetManager.Ekle2("elma", "amasya elması", 12,  9);
            sepetManager.Ekle2("karpuz", "hakiki karpuz", 12, 8);
        }
    }
}
