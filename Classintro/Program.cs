using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            bool medenihal = false;
            string mesaj = medenihal == true ? "evliye kampanya" : "bekara kampanya";
            kurs dersler1 = new kurs();
            dersler1.ders = "csharp";
            dersler1.seviye = "iyi";
            kurs dersler2 = new kurs();
            dersler2.ders = "unity";
            dersler2.seviye = "dahaiyi";
            Console.WriteLine(dersler2.ders+" "+dersler2.seviye);
            kurs[] kurslar = new kurs[] { dersler1, dersler2 };
            foreach (var bolum in kurslar)
            {
                Console.WriteLine(bolum.seviye  );
            }
            Console.WriteLine("Hello World!");
        }
    }
    class kurs
    {
        public string ders { get; set; }
        public string seviye { get; set; }

    }
    
}
