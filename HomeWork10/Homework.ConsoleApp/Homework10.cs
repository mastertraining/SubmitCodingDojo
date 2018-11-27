using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Homework.ConsoleApp
{
    public class Homework10 : IHomework10
    {
        public List<Product> Cart { get; set; }
        private string _part { get; set; }
        private string _filePath { get; set; }

        public Homework10()
        {
            Cart = new List<Product>();
            _part = @"product.csv";
            _filePath = @"cart.json";
            var jsonString = LoadSavedCart();
            if (!string.IsNullOrEmpty(jsonString))
            {
                Cart = JsonConvert.DeserializeObject<List<Product>>(jsonString);
            }
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            var products = new List<Product>();
            using (var reader = new StreamReader(_part))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var product = new Product();
                    product.SKU = values[0];
                    product.Name = values[1];
                    product.Price = double.Parse(values[2]);

                    products.Add(product);
                }
            }
            return products;
        }

        public void AddProductToCart(IProduct product) => Cart.Add(product as Product);

        public IEnumerable<IProduct> GetProductsInCart() => Cart;

        public void SaveCurrentState()
        {
            var jsonData = JsonConvert.SerializeObject(Cart, Formatting.Indented);
            FileReader.WriteTextToDataFile(_filePath, jsonData);
        }

        public string LoadSavedCart()
        {
            var jsonString = FileReader.ReadTextFromDataFile(_filePath);
            return jsonString;
        }
    }
}