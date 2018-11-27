using System;
using System.Text;
using System.Collections.Generic;

public static class Program
{
    static void Main(string[] args)
    { //**** เหลือสร้าง display ใช่ strinbuilder *****/
        var hm10 = new Homework10();
        var input = Console.ReadLine().Split(',');
        var sku = input[0];
        int amount;
        amount = (int.TryParse(input[1], out amount))? int.Parse(input[1]) : 1;

        foreach (IProduct value in hm10.GetAllProducts())
        {
            if (string.Equals(sku, value.SKU))
            {
                for (int i = 0; i < amount; ++i)
                {
                    hm10.AddProductToCart(value);
                }
            }
        }
        hm10.SaveCurrentState();

        foreach(IProduct value in hm10.cart)
        {
            Console.WriteLine(value.Name);
        }
    }

}
