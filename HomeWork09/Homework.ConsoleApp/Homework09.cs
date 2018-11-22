using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework.ConsoleApp
{
    public class Homework09 : IHomework09
    {
        private List<Product> Cart = new List<Product>();
        private string _part = @"C:\Users\Computer\Desktop\CodingDojo\HomeWork09\Homework.ConsoleApp\product.csv";

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
    }
}