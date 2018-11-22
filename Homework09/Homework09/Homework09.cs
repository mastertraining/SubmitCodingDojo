using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework09
{
    public class Homework09 : IHomework09
    {
        private string path { get; set; }
        private IList<IProduct> myCart { get; set; }
        private IEnumerable<IProduct> allProduct { get; set; }

        public Homework09()
        {
            path = @"product.csv";
            myCart = new List<IProduct>();
            allProduct = GetAllProducts();
            DisplayPOS();
        }

        public void GetProductById(string productid)
        {
            var selecdProduct = allProduct.FirstOrDefault(it => it.SKU == productid);
            AddProductToCart(selecdProduct);
        }

        public void AddProductToCart(IProduct product)
        {
            if (product != null) myCart.Add(product);
            else Console.WriteLine("Your ProductId is invalid !");
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            using (var reader = File.OpenText(path))
            using (var csv = new CsvReader(reader))
            {
                var records = csv.GetRecords<Product>().ToList();
                return records;
            }
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            return myCart;
        }

        public string FormatCurrency(double input)
        {
            var sum = myCart.Select(it => it.Price).Sum();
            return String.Format("{0:#,##0.00}", input);
        }

        public void DisplayPOS()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Products in your cart are");
            var cart = myCart;
            if (cart == null || cart.Count() == 0)
            {
                builder.AppendLine("None");
            }
            else
            {
                var index = 1;
                foreach (var item in cart)
                {
                    builder.Append($"{index}.").Append(String.Format("{0,-28}{1,10}", item.Name, FormatCurrency(item.Price))).AppendLine();
                    index++;
                }
            }
            builder.Append('-', 3).AppendLine().Append($"Total amount: {FormatCurrency(cart.Select(it => it.Price).Sum())} baht");
            Console.WriteLine(builder.ToString());
        }
    }

    public class Product : IProduct
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
