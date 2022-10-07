using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Xml.Schema;

namespace KampIntro
{


    class Program
    {

        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Yunus" , "Ali" , "Ahmet" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
           
            //isimler = new string[4];
            //isimler[3] = "İlker";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[0]);  
            
            List<string> isimler2 = new List<string> {"Yunus","Ali","Ahmet","İlker" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Emre");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            

        }
    }



}