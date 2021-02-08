using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi!"+product.ProductName);
        }
    }
}
