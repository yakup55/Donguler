using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Ekle(Urün urün)
        {
            Console.WriteLine("tebrikler sepete eklendi: "  +  urün.Adi);
        }


        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("tebrikler. sepete eklendi:"+urunAdi);
        }

    }
}
