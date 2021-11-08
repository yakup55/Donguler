using System;

namespace DegerveReferansTıpler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int decimal fload benzeri deger tip
            int sayı1 = 10;
            int sayı2 = 30;

            sayı1 = sayı2;
            sayı2 = 65;

            //sayı1 = 30;

           // Console.WriteLine(sayı1);
           // array class intercase referans tip
            int[] sayılar1 = new[] { 10, 20, 30 };
            int[] sayılar2 = new[] { 100, 200, 300 };
            sayılar1 = sayılar2;
            sayılar2[0]=999;

            //sayılar1[0]=999;

            // Console.WriteLine(sayılar1);

        }
    }
}
