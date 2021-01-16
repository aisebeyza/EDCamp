using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "apple";
            double cost = 15;
            string description = "amasya apple";

            string[] fruits = new string[] {"Apple" };

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Cost = 15;
            product1.Description = "amasya apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Cost = 8;
            product2.Description = "diyarbakır watermelon";

            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products )
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Cost);
                Console.WriteLine(product.Description);
                Console.WriteLine("***********");
            }

            Console.WriteLine("*********methods*******");

            //instance
            //encapsulation

            CartManager cartmanager = new CartManager();
            cartmanager.Add(product1);
            cartmanager.Add(product2);

            cartmanager.Sum2("Pear","Green Pear",12,8);
        }
    }
}
//method:tekrar tekrar kullanılabilirliği sağlayan yapılardır.
//DRY