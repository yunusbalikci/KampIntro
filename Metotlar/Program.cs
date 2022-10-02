using Metotlar;
using System;

namespace KampIntro
{


    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };

            Product Prod1 = new Product();
            Prod1.Adi = "Elma";
            Prod1.Fiyat = 15;
            Prod1.Aciklama = "Amasya Elması";
            Prod1.StokAdedi = 111;

            Product Prod2 = new Product();
            Prod2.Adi = "Karpuz";
            Prod2.Aciklama = "Diyarbakır";
            Prod2.Fiyat = 20;
            Prod2.StokAdedi = 33;

            Product[] products = new Product[] { Prod1, Prod2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.StokAdedi);
                Console.WriteLine(" ");
            }

            Console.WriteLine("--Metotlar--");
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Prod1);
            sepetManager.Ekle(Prod2);


        }
    }
}
