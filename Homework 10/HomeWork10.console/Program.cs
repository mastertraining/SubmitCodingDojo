using System;
using System.Linq;
using HomeWork10.classlib;
using System.Collections.Generic;
namespace HomeWork10.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw10 = new HomeWork10ClassLib();
            hw10.setDefaultCart();
            var getAllProduct = hw10.GetAllProducts().ToList();
            var skuNo = "none";
            var amount = 0;
            var balance = 0.00;
            var purchase = new List<string>();
            var checkStringToInt = true;
            foreach (var products in getAllProduct)
            {
                Console.WriteLine($"{products.SKU} , {products.Name} , {products.Price,2:N}");
            }
            Console.WriteLine(new string('=', 60));

            while (true)
            {
                var getProductInCart = hw10.GetProductsInCart().ToList();
                Console.WriteLine("Products in your cart are");
                if (!getProductInCart.Any())
                {
                    Console.WriteLine("none");
                }
                else
                {
                    var count = 1;
                    foreach (var productCart in getProductInCart)
                    {
                        Console.WriteLine($"{count}.{productCart.Name}\t({hw10.countProduct[productCart.SKU]}) {productCart.Price,2:N}");
                        count++;
                    }
                }
                Console.WriteLine(new string('-', 3));
                Console.WriteLine($"Total amount: {balance,2:N} baht");
                Console.Write($"Please input a product key: ");
                var inputPurchase = Console.ReadLine();
                if (inputPurchase.Contains(','))
                {
                    purchase = inputPurchase.Split(',').ToList();
                    checkStringToInt = int.TryParse(purchase[1], out int amountProduct);
                    skuNo = purchase[0];
                    amount = checkStringToInt ? amountProduct : amountProduct;
                    // amount = amountProduct;
                    hw10.countProduct["skuNo"] += amount;
                }
                else
                {
                    skuNo = inputPurchase;
                    hw10.countProduct[skuNo] = amount + 1;
                }
                var addToCart = getAllProduct.FirstOrDefault(it => it.SKU == skuNo);
                var checkDuplicateProduct = hw10.listCart.Select(it => it.SKU == skuNo).ToList();
                if (checkDuplicateProduct.Any())
                {
                    // foreach (var productCart in getProductInCart) {
                    //     productCart.SKU = skuNo;
                    //     productCart.Add(addToCart);
                    // }
                    // getProductInCart.Remove(addToCart);
                    hw10.countProduct[skuNo] += amount;
                    // hw10.AddProductToCart(addToCart);
                }
                else
                {
                    hw10.AddProductToCart(addToCart);
                    hw10.countProduct[skuNo] += amount;
                }
                balance += addToCart.Price * hw10.countProduct[skuNo];
                Console.WriteLine(new string('=', 60));
            }
        }
    }
}
