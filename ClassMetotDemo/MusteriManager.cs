using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Cutomer cutomer)
        {
            Console.WriteLine("müşteri adı eklendi"+cutomer.adi);
           
          
        }
        public void Silme(Cutomer cutomer)
        {
            Console.WriteLine("müşteri adı silindi" + cutomer.adi);
      

        }
    }
}
