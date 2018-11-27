using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework10
{
    public class Homework10 : IHomework10
    {
        private const string pathProduct = @"product.csv";
        private const string pathSave = @"savestate.json";
        private List<Product> myCart { get; set; }
        private IEnumerable<IProduct> allProduct { get; set; }

        public Homework10()
        {
            var _myCart = LoadSavedCart();
            myCart = JsonConvert.DeserializeObject<List<Product>>(_myCart);
            allProduct = GetAllProducts();
            DisplayPOS();
        }

        public void GetProductById(string input)
        {
            var splited = input.Split(',');
            var selecdProduct = allProduct.FirstOrDefault(it => it.SKU == splited[0]);
            var count = splited.Length > 1 && int.TryParse(splited[1], out var quantity) && quantity > 0 ? quantity : 1;
            if (selecdProduct != null)
            {
                for (int i = 0; i < count; i++)
                {
                    AddProductToCart(selecdProduct);
                }
            }
            else Console.WriteLine("Your ProductId is invalid !");
        }

        public void AddProductToCart(IProduct product)
        {
            myCart.Add(product as Product);
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            using (var reader = File.OpenText(pathProduct))
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
            var cart = myCart.GroupBy(it => it.SKU);
            if (cart.Any())
            {
                var index = 1;
                foreach (var item in cart)
                {
                    builder.Append($"{index}.").Append(String.Format("{0,-28}({1}){2,10}", item.FirstOrDefault().Name, item.Count(), FormatCurrency(item.FirstOrDefault().Price)))
                    .AppendLine();
                    index++;
                }
            }
            else
            {
                builder.AppendLine("None");
            }
            builder.Append('-', 3).AppendLine().Append($"Total amount: {FormatCurrency(myCart.Sum(it => it.Price))} baht");
            Console.WriteLine(builder.ToString());
        }

        public void SaveCurrentState()
        {
            var jsonData = JsonConvert.SerializeObject(myCart, Formatting.Indented);
            File.WriteAllText(pathSave, jsonData);
            Console.WriteLine("Current state had been saved!");
        }

        public string LoadSavedCart()
        {
            using (var fi = File.OpenText(pathSave))
            {
                return fi.ReadToEnd();
            }
        }
    }

    public class Product : IProduct
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
