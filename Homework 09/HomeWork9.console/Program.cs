using System;
using HomeWork9.classlib;
using System.Linq;
using System.Text;

namespace HomeWork9.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw9 = new HomeWork9ClassLib();
            var sb = new StringBuilder();
            var balance = 0.00;
            var getAll = hw9.GetAllProducts();
            foreach (var listP in getAll)
            {
                Console.WriteLine($"{listP.SKU} , {listP.Name} , {listP.Price,2:N}");
            }
            Console.WriteLine(new string('=', 30));
            hw9.setDefaultCart();

            while (true)
            {
                Console.WriteLine("Products in your cart are");
                var getProductInCart = hw9.GetProductsInCart().ToList();
                if (!getProductInCart.Any())
                {
                    Console.WriteLine("none");
                }
                else
                {
                    for (int i = 0; i < getProductInCart.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.{getProductInCart[i].Name}\t{getProductInCart[i].Price,2:N}");
                    }
                }
                Console.WriteLine("---");
                Console.WriteLine($"Total amount: {balance,2:N} baht");
                Console.Write("Please input a product key: ");
                var skuProduct = Console.ReadLine();
                var addTOCart = getAll.FirstOrDefault(it => it.SKU == skuProduct);
                hw9.AddProductToCart(addTOCart);
                balance += addTOCart.Price;
                Console.WriteLine(new string('=', 60));
            }
        }
    }
}
