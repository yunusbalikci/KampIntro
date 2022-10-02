using System;

namespace KampIntro
{


    class Program
    {

        static void Main(string[] args)
        {

            int sayi1 = 10;
            int sayi2 = 20;
            sayi1= sayi2;
            sayi2 = 34;
            //sayi1 = 20

            int[] sayilar1= new int[] {10,20,30};
            int[] sayilar2= new int[] {100,200,300};
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //sayilar1[0]= 999



        }
    }



}