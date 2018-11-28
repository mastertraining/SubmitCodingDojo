using System;
using System.Linq;
using hw10ClassLib;

namespace hw10Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var call = new Homework10();
            var amount = 0.00;
            var input = " ";
            var getAllProduct = call.GetAllProducts().ToList();
            var massage = "Current state had been saved!";

            while (true)
            {
                var productsInCart = call.GetProductsInCart().ToList();
                var products = productsInCart.GroupBy(it => it.SKU);
              
                Console.WriteLine("Products in your cart are");

                if (productsInCart.Capacity == 0)
                {
                    Console.WriteLine("none");
                }
                else
                {
                    var no = 1;
                    foreach (var item in products)
                    {
                        Console.WriteLine($"{no}.{item.First().Name,-29:G} ({item.Count()}) {item.First().Price,2:N}");
                        no++;
                    }
                }

                Console.WriteLine("---");
                Console.WriteLine($"Total amount: {amount,2:N} baht");
                Console.Write("Please input a product key: ");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                else if (input == "save")
                {
                    call.SaveCurrentState();
                    Console.WriteLine(massage);
                    amount = amount;
                }
                else if (input.Contains(','))
                {
                    var split = input.Split(',').ToList();
                    var value = int.TryParse(split[1], out int test) ? int.Parse(split[1]) : 1;

                    var addToCart = getAllProduct.Find(it => it.SKU == split[0]);

                    for (int i = 0; i < value; i++)
                    {
                        call.AddProductToCart(addToCart);
                    }
                    amount += addToCart.Price;
                    Console.WriteLine();
                }
                else
                {
                    var addToCart = getAllProduct.Find(it => it.SKU == input);

                    call.AddProductToCart(addToCart);
                    amount += addToCart.Price;
                    Console.WriteLine();
                }
            }
        }
    }
}
