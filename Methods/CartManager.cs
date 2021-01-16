using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Added to cart: "+ product.Name);
            
        }

        public void Sum2(string productName, string description, double cost,int StockQuantity)
        {
            Console.WriteLine("Added to cart: "+ productName);
        }
    }
}
