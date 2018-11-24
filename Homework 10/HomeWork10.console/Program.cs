using System;
using System.Linq;
using HomeWork10.classlib;
using System.Collections.Generic;
namespace HomeWork10.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw10 = new HomeWork10ClassLib();
            hw10.setDefaultCart();
            var getAllProduct = hw10.GetAllProducts().ToList();
            var skuNo = "none";
            var amount = 0;
            var balance = 0.00;
            foreach (var products in getAllProduct)
            {
                Console.WriteLine($"{products.SKU} , {products.Name} , {products.Price,2:N}");
            }
            Console.WriteLine(new string('=', 60));

            while (true)
            {
                var getProductInCart = hw10.GetProductsInCart();
                Console.WriteLine("Products in your cart are");
                if (!getProductInCart.Any())
                {
                    Console.WriteLine("none");
                }
                else
                {
                    var count = 1;
                    foreach (var productCart in getProductInCart)
                    {
                        Console.WriteLine($"{count}.{productCart.Name}\t({productCart.amount}) {productCart.Price,2:N}");
                        count++;
                    }
                }
                Console.WriteLine(new string('-', 3));
                Console.WriteLine($"Total amount: {balance,2:N} baht");
                Console.Write($"Please input a product key: ");
                var inputPurchase = Console.ReadLine();
                if (inputPurchase.Contains(','))
                {
                    var purchase = inputPurchase.Split(',').ToList();
                    int.TryParse(purchase[1], out int amountProduct);
                    skuNo = purchase[0];
                    amount = amountProduct;
                }
                var addToCart = getAllProduct.FirstOrDefault(it => it.SKU == skuNo);
                hw10.AddProductToCart(addToCart);
              
                balance += addToCart.Price * amount;
                Console.WriteLine(new string('=', 60));
            }

        }
    }
}
