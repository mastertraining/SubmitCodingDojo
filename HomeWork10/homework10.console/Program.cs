using System;
using System.Linq;
using System.Text;
using homework10.lib;

namespace homework10.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var pos = new Homework10();
            var products = pos.GetAllProducts();

            var displayProducts = new StringBuilder();
            displayProducts.AppendLine("Current product in POS");
            displayProducts.AppendLine("\tSKU\tName\t\t\t\tPrice");
            foreach (var item in products)
            {
                displayProducts.AppendLine($"\t{item.SKU,-7} {item.Name,-31} {item.Price.ToString("N2")}");
            }
            var rules = $"Rules Input{Environment.NewLine}\t'list' to display current product{Environment.NewLine}\t'exit' to exit program{Environment.NewLine}\t'save' to save current cart{Environment.NewLine}\t'load' to load saved cart{Environment.NewLine}\t'<product-SKU>' or '<product-SKU>,<add-to-cart-amount>' to add product(s) to cart";
            Console.Write($"Hello Welcome to POS analysis (HomeWork 09){Environment.NewLine}{displayProducts}{Environment.NewLine}{rules}{Environment.NewLine}");

            var isContinueInputLedOnScreen = true;
            while (isContinueInputLedOnScreen)
            {
                System.Console.WriteLine($"{new string('=', 60)}{Environment.NewLine}Products in your cart are");
                var orderProducts = pos.GetProductsInCart().ToList();
                if (orderProducts.Any())
                {
                    var group = orderProducts.GroupBy(it => it.Name);
                    var index = 1;
                    foreach (var item in group)
                    {
                        System.Console.WriteLine($"{index++}.{item.Key,-30} ({item.Count()}) {item.FirstOrDefault().Price.ToString("N2")}");
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
                    case "load": System.Console.WriteLine(pos.LoadSavedCart()); break;
                    case "save": pos.SaveCurrentState(); break;
                    default:

                        var inputSplited = input.Split(',');
                        var productId = inputSplited.FirstOrDefault();
                        var product = products.FirstOrDefault(it => it.SKU.Equals(productId, StringComparison.CurrentCultureIgnoreCase));
                        var isProductExist = product != null;
                        if (!isProductExist)
                        {
                            System.Console.WriteLine($"Has not any product's key: {productId} in POS, Please try again");
                            break;
                        }

                        const int MinimumAmount = 1;
                        var amountText = inputSplited.LastOrDefault();
                        int.TryParse(amountText, out int amount);
                        if (amount < MinimumAmount) amount = MinimumAmount;
                        for (int i = 0; i < amount; i++)
                        {
                            pos.AddProductToCart(product);
                        }
                        break;
                }
            }
            System.Console.WriteLine("Exit program!");
        }
    }
}
