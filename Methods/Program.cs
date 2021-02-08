using System;

namespace Methods
{
    //Dont repeat yourself - DRY - Clean Code - Best Practice
    class Program
    {
        static void Main(string[] args)
        {
            Product product2 = new Product();
            product2.ProductName = "Domates";
            product2.Price = 7;
            product2.Comment = "Çeri domates";

            Product product3 = new Product();
            product3.ProductName = "Biber";
            product3.Price = 12;
            product3.Comment = "Kapya biber";

            Product product = new Product();
            product.ProductName = "Elma";
            product.Price = 10;
            product.Comment = "Amasya elması";

            Product product1 = new Product();
            product1.ProductName = "Çilek";
            product1.Price = 15;
            product1.Comment = "Tatlı bal çilek";

          

            Product[] products = new Product[] {product,product1,product2,product3};
            foreach (Product produc in products)
            {
                Console.WriteLine(produc.ProductName+" : "+produc.Price+" TL"+" "+ produc.Comment);
                Console.WriteLine("----------------");
            }
           

            Console.WriteLine("------Methods-----");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product);
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add(product3);

        }
    }
}
