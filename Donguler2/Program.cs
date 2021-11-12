using System;

namespace Donguler2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "csharp", "unity", "java" };
            for (int i = 0; i <kurslar.Length;i++)// i += 2)  //i = i + 2;
            {
                Console.WriteLine();
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
