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
            var checkStringToInt = true;

            foreach (var products in getAllProduct)
            {
                Console.WriteLine($"{products.SKU} , {products.Name} , {products.Price,2:N}");
            }
            Console.WriteLine(new string('=', 60));

            hw10.Load();
            while (true)
            {
                var checkSave = false;
                var getProductInCart = hw10.GetProductsInCart().ToList();
                hw10.balance = 0;
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
                        Console.WriteLine($"{count}.{productCart.Name}\t({hw10.countProduct[productCart.SKU]}) {productCart.Price,2:N}");
                        hw10.balance += productCart.Price * hw10.countProduct[productCart.SKU];
                        count++;
                    }
                }
                Console.WriteLine(new string('-', 3));
                Console.WriteLine($"Total amount: {hw10.balance,2:N} baht");
                Console.Write($"Please input a product key: ");
                var inputPurchase = Console.ReadLine();
                var purchase = new List<string>();

                if (inputPurchase == "save")
                {
                    hw10.SaveCurrentState();
                    checkSave = true;
                }
                else
                {
                    if (inputPurchase.Contains(','))
                    {
                        purchase = inputPurchase.Split(',').ToList();
                        checkStringToInt = int.TryParse(purchase[1], out int amountProduct);
                        skuNo = purchase[0];
                        hw10.amount = checkStringToInt ? amountProduct : 1;
                    }
                    else
                    {
                        skuNo = inputPurchase;
                        hw10.amount = 1;
                    }
                    var addToCart = getAllProduct.FirstOrDefault(it => it.SKU == skuNo);
                    hw10.AddProductToCart(addToCart);
                }

                Console.WriteLine(new string('=', 60));
                var messageSave = checkSave ? "Current state had been saved!" : null;
                Console.WriteLine(messageSave);
            }
        }
    }
}
