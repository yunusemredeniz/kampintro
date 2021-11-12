using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            product meyve1 = new product();
            meyve1.Adi = "elma";
            meyve1.Fiyati = 15;
            product meyve2 = new product();
            meyve2.Adi = "karpuz";
            meyve2.Fiyati = 30;
            product[] meyveler = new product[] { meyve1, meyve2 };
            foreach (product meyve in meyveler)
            {
                Console.WriteLine(meyve.Adi);
                Console.WriteLine(meyve.Fiyati);
                Console.WriteLine("---------------------");
            }
            //instance örnek
            Console.WriteLine("----------metodlar--------------");
            Sepetmanager sepetmanager = new Sepetmanager();
            sepetmanager.ekle(meyve1);
            sepetmanager.ekle(meyve2);
            //encapsulation

        }
    }
}
//dry clean code best practice