using OOP1;
using System;

namespace KampIntro
{


    class Program
    {

        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 5;

            Product product2 = new Product {Id = 8, UnitsInStock = 44, UnitPrice = 64 , CategoryId = 5,
                ProductName ="Kalem" };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);





             



        }
    }



}