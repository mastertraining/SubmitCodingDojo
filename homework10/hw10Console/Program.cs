using System;
using System.IO;
using System.Linq;
using System.Text;
using hw10ClassLib;

namespace hw10Console
{
    class Program
    {
        private static string _pathSumAmount = @"amount.txt";
        static void Main(string[] args)
        {

            var call = new Homework10();
            var amount = double.Parse(getAmount());
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
                    WriteAmonut(amount.ToString());

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
        static string getAmount()
        {
            var read = File.ReadLines(_pathSumAmount, Encoding.UTF8).Last();
            return read;
        }
        static void WriteAmonut(string amount)
        {
            var write = new StreamWriter(_pathSumAmount);
            write.WriteLine($"{amount}.00");
            write.Close();
        }
    }
}
