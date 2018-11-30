using System;
using System.Collections.Generic;
using System.Linq;
using hw9ClassLib;

namespace hw9Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var call = new Homework09();
            var amount = 0.00;
            var input = "";
            var getAllProduct = call.GetAllProducts().ToList();

            while (true)
            {
                var productsInCart = call.GetProductsInCart().ToList();

                Console.WriteLine();
                Console.WriteLine("Products in your cart are");

                if (productsInCart.Capacity == 0)
                {
                    Console.WriteLine("none");
                }
                else
                {
                    var no = 1;

                    foreach (var item in productsInCart)
                    {
                        Console.WriteLine($"{no}.{item.SKU},{item.Name},{item.Price,2:N}");
                        no++;
                    }
                }

                Console.WriteLine("---");
                Console.WriteLine($"Total amount: {amount,2:N} baht");
                Console.Write("Please input a product key:");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                var addToCart = getAllProduct.Find(it => it.SKU == input);

                call.AddProductToCart(addToCart);
                amount += addToCart.Price;
            }
        }
    }
}

