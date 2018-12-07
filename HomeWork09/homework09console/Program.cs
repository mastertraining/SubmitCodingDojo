using System;
using System.Linq;
using homework09;

namespace homework09console
{
    class Program
    {
        static void Main(string[] args)
        {
            var sut = new ProductLogic();
            var allProduct = sut.GetAllProducts();
            var balance = 0.00;
            foreach (var productList in allProduct)
            {
                Console.WriteLine($"{productList.SKU} , {productList.Name} , {productList.Price}");
            }
            Console.WriteLine(new string('=', 30));
            sut.setCart();
            var setInCart = true;
            while (setInCart)
            {
                Console.WriteLine("Products in your cart are");                
            }
        }
    }
}
