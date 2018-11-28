﻿using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public static class Program
{
    static void Main(string[] args)
    {
        var hm10 = new Homework10();
        double totalPrice = 0;
        while (true)
        {
            Console.WriteLine("Products in your cart are");
            int n = 1;
            int amount;
            string sku;
            string[] input;
            StringBuilder CountOrder;

            if (hm10.cart.Any())
            {
                List<int> amountOfItemInCart = new List<int>();
                List<Tuple<IProduct, int>> xx/*ProductItemsAndAmountOfDuplicateItems*/ = new List<Tuple<IProduct, int>>();

                {
                    CountOrder = new StringBuilder();
                    CountOrder.Append("(").Append(x.Count).Append(")");
                    Console.Write(string.Format("{0}.{1,10}", n, x.product.Name));
                    Console.WriteLine(string.Format("{0,20} {1:N}", CountOrder.ToString(), x.product.Price));
                    n++;
                }
            }
            else
            {
                Console.WriteLine("none");
            }


            Console.WriteLine("---");
            Console.WriteLine(string.Format("Total amount: {0:N} baht", totalPrice));
            Console.Write("Please input a product key: ");

            input = Console.ReadLine().Split(',');
            sku = input[0];
            amount = (int.TryParse(input[1], out amount)) ? int.Parse(input[1]) : 1;

            foreach (IProduct value in hm10.GetAllProducts())
            {
                if (string.Equals(sku, value.SKU))
                {
                    for (int i = 0; i < amount; ++i)
                    {
                        hm10.AddProductToCart(value);
                        totalPrice += value.Price;
                    }
                }
            }
            hm10.SaveCurrentState();
        }
    }
}
