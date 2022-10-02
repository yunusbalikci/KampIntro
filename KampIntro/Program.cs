using System;

namespace KampIntro
{


    class Program
    {

        static void Main(string[] args)
        {
            string KategoriEtiket = "Etiket";
            int OgrenciSayisi = 32000;
            bool SistemeGirisYapmisMi = true;
            double dolarDun = 15.15;
            double dolarBugun = 15.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalma butonu");

            }

            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi");

            }
            if (SistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarı Butonu");
            }
            else 
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(KategoriEtiket);

        }
    }
}


