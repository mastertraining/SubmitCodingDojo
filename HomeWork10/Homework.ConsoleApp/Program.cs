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
            var PoS = new Homework10();
            var allProducts = PoS.GetAllProducts();
            var price = 0.00;
            var key = "start";
            Console.WriteLine("Products in your cart are");

            do
            {
                var productsInCart = PoS.GetProductsInCart().ToList();
                var products = productsInCart.GroupBy(it => it.SKU);

                if (products.Any())
                {
                    var index = 1;
                    foreach (var item in products)
                    {
                        Console.WriteLine($"{index}.{item.First().Name,-27:G}({item.Count()}) {item.First().Price,2:N}");
                        index++;
                    }
                }
                else
                {
                    Console.WriteLine("none");
                }

                Console.WriteLine("---");
                Console.WriteLine($"Total amount: {price,2:N} baht");
                Console.Write("Please input a product key: ");
                var input = Console.ReadLine();
                Console.WriteLine();
                
                var orders = input.Split(',');
                key = orders[0];
                var value = (orders.Length > 1 && int.TryParse(orders[1], out int test)) ? int.Parse(orders[1]) : 1;

                if (allProducts.Any(it => it.SKU == key))
                {
                    var product = allProducts.FirstOrDefault(it => it.SKU == key);
                    for (int i = 0; i < value; i++)
                    {
                        PoS.AddProductToCart(product);
                    }
                    price += product.Price;
                }
                else if (key == "save")
                {
                    PoS.SaveCurrentState();
                    Console.WriteLine("Current state had been saved!");
                }
                else if (string.IsNullOrEmpty(key))
                {
                    Console.WriteLine("*** Thank you. ***");
                }
                else
                {
                    Console.WriteLine("*** This product is not available. ***");
                }

                Console.WriteLine("Products in your cart are");

            } while (!string.IsNullOrEmpty(key));
        }
    }
}