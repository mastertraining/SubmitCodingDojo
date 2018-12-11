using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var PoS = new Homework09();
            var allProducts = PoS.GetAllProducts();
            var productsInCart = new List<IProduct>();
            var amount = 0.00;
            var key = "start";

            do
            {
                Console.WriteLine();
                Console.WriteLine("Products in your cart are");

                productsInCart = PoS.GetProductsInCart().ToList();

                if (productsInCart.Any())
                {
                    for (int i = 0; i < productsInCart.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.{productsInCart[i].Name}\t{productsInCart[i].Price,2:N}");
                    }
                }
                else
                {
                    Console.WriteLine("none");
                }

                Console.WriteLine("---");
                Console.WriteLine($"Total amount: {amount,2:N} baht");
                Console.Write("Please input a product key: ");

                key = Console.ReadLine();

                if (allProducts.Any(it => it.SKU == key))
                {
                    var product = allProducts.FirstOrDefault(it => it.SKU == key);
                    PoS.AddProductToCart(product);
                    amount += product.Price;
                }
                else if (string.IsNullOrEmpty(key))
                {
                    Console.WriteLine("*** Thank you. ***");
                }
                else
                {
                    Console.WriteLine("*** This product is not available. ***");
                }

            } while (!string.IsNullOrEmpty(key));
        }
    }
}