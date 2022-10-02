using System;

namespace KampIntro
{


    class Program
    {

        static void Main(string[] args)
        {
            string kurs1 = "Java";
            string kurs2 = "C++";
            string kurs3 = "C#";
            string kurs4 = "Python";

            string[] kurslar = new string[] { "Java", "C++", "C#", "Python","C" };
            
            for (int i = 1; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("FOR bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu");
        }
    }
}

