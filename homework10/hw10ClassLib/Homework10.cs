using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace hw10ClassLib
{
    public class Homework10 : IHomework10
    {
        public List<Product> Cart = new List<Product>();
        private List<Product> _products = new List<Product>();
        private string _pathProduct = @"..\hw10Console\product.csv";
        private string _pathCart = @"..\hw10Console\cart.json";

        public Homework10()
        {
            var jsonString = LoadSavedCart();
            if (!string.IsNullOrEmpty(jsonString))
            {
                Cart = JsonConvert.DeserializeObject<List<Product>>(jsonString);
            }
        }

        public void AddProductToCart(IProduct product)
        {
            Cart.Add(product as Product);
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            using (var reader = new StreamReader(_pathProduct))
            {
                while (!reader.EndOfStream)
                {
                    var read = reader.ReadLine();
                    var values = read.Split(',');

                    Double.TryParse(values[2], out double priceDouble);
                    _products.Add(new Product
                    {
                        SKU = values[0],
                        Name = values[1],
                        Price = priceDouble,
                    });
                }
            }

            return _products;
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            return Cart;
        }

        public string LoadSavedCart()
        {
            var jsonString = FileReader.ReadTextFromDataFile(_pathCart);
            return jsonString;
        }

        public void SaveCurrentState()
        {
            var jsonData = JsonConvert.SerializeObject(Cart, Formatting.Indented);
            FileReader.WriteTextToDataFile(_pathCart, jsonData);
        }
    }
}
