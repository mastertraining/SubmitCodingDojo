using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using Homework_10.Model;
using Newtonsoft.Json;

namespace Homework_10
{
    public class Homework10 : IHomework10
    {
        private IList<IProduct> cart;
        private IList<IProduct> products;
        private readonly string productInCartPath = @"cart.json";
        private readonly string productsPath = @"product.csv";
        public Homework10() => LoadSavedCart();

        public void AddProductToCart(IProduct product)
        {
            if (product == null) return;
            product = products.FirstOrDefault(it => it.SKU == product.SKU);
            if (product != null) cart.Add(product);
        }

        public IEnumerable<IProduct> GetAllProducts() => products;
        public IEnumerable<IProduct> GetProductsInCart() => cart;

        public string LoadSavedCart()
        {
            cart = ReadProductInCartFile().ToList();
            products = ReadProductFile().ToList();
            return "Load Completed!";
        }

        private IEnumerable<IProduct> ReadProductInCartFile()
        {
            if (!File.Exists(productInCartPath)) return new List<IProduct>();
            var textJson = File.ReadAllText(productInCartPath);
            return JsonConvert.DeserializeObject<List<Product>>(textJson);
        }

        private IEnumerable<IProduct> ReadProductFile()
        {
            if (!File.Exists(productsPath)) return new List<IProduct>();
            using (var reader = File.OpenText(productsPath))
            using (var csv = new CsvReader(reader))
            {
                return csv.GetRecords<Product>().ToList();
            }
        }

        public void SaveCurrentState()
        {
            using (var writer = File.CreateText(productInCartPath))
            {
                var productsJson = JsonConvert.SerializeObject(cart, Formatting.Indented);
                writer.WriteLine(productsJson);
            }
        }
    }
}
