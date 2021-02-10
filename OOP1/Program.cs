using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Çalışma masası";
            product1.UnitPrice = 600;
            product1.UnitsInStock = 4;

            Product product2 = new Product { 
                Id = 2, 
                CategoryId = 4, 
                UnitsInStock = 2,
                ProductName="Bilgisayar",
                UnitPrice=8000 
            };

            //PascalCase   //camelCase
            //case sensitive
            ProductService productService = new ProductService();
            productService.Add(product1);
            Console.WriteLine(product2.ProductName);

            
        }
    }
}
