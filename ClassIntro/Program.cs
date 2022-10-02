using System;

namespace KampIntro
{


    class Program
    {

        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = ("Engin");
            kurs1.IzlenmeOranı = 68;
            kurs1.KursAdi = ("Java");

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = ("Engin");
            kurs2.IzlenmeOranı = 50;
            kurs2.KursAdi = ("C++");

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = ("Engin");
            kurs3.IzlenmeOranı = 77;
            kurs3.KursAdi = ("Python");


            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen + " " + kurs.KursAdi) ;


            }

                
            
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }


}
