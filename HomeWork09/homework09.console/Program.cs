using System;
using System.Text;
using System.Linq;
using homework09.lib;

namespace homework09.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var pos = new Homework09();
            var products = pos.GetAllProducts();

            var displayProducts = new StringBuilder();
            displayProducts.AppendLine("Current product in POS");
            displayProducts.AppendLine("\tSKU\tName\t\t\t\tPrice");
            foreach (var item in products)
            {
                displayProducts.AppendLine($"\t{item.SKU}\t{item.Name}\t\t\t{item.Price.ToString("N2")}");
            }
            var rules = $"Rules{Environment.NewLine}\tInput 'list' to display current product{Environment.NewLine}\tInput: 'exit' to exit program{Environment.NewLine}\tInput: number each SKU for add to cart";
            Console.Write($"Hello Welcome to POS analysis (HomeWork 09){Environment.NewLine}{displayProducts}{Environment.NewLine}{rules}{Environment.NewLine}");

            var isContinueInputLedOnScreen = true;
            while (isContinueInputLedOnScreen)
            {
                System.Console.WriteLine($"{new string('=', 60)}{Environment.NewLine}Products in your cart are");
                var orderProducts = pos.GetProductsInCart().ToList();
                if (orderProducts.Any())
                {
                    for (int i = 0; i < orderProducts.Count(); i++)
                    {
                        var product = orderProducts[i];
                        System.Console.WriteLine($"{i + 1}.{product.Name}\t{product.Price.ToString("N2")}");
                    }
                }
                else System.Console.WriteLine($"none");

                System.Console.WriteLine($"---{Environment.NewLine}Total amount: {orderProducts.Sum(it => it.Price).ToString("N2")} baht");
                System.Console.Write("Please input a product key: ");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "exit": isContinueInputLedOnScreen = false; break;
                    case "list": System.Console.WriteLine(displayProducts); break;
                    default:

                        var product = products.FirstOrDefault(it => it.SKU.Equals(input, StringComparison.CurrentCultureIgnoreCase));
                        var isProductExist = product != null;
                        if (!isProductExist)
                        {
                            System.Console.WriteLine($"Has not any product's key: {input} in POS, Please try again");
                            break;
                        }

                        pos.AddProductToCart(product);
                        break;
                }
            }
            System.Console.WriteLine("Exit program!");
        }
    }
}
