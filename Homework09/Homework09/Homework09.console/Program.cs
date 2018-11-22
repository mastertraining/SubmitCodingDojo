using System;
using System.Linq;

namespace Homework09.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Homework09();
            while(true)
            {
                svc.GetProductById(Console.ReadLine());
                var productInCart = svc.GetProductsInCart();
                foreach (var item in productInCart)
                {
                    Console.WriteLine($"{item.SKU}:{item.Name}:{item.Price}");
                }
                Console.WriteLine(svc.GetCartSummary());
            }
        }
    }
}
