using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homework09
{
    class Homework09Logic : IHomework09
    {
        private const string FileName = @"product.csv";
        private List<Product> _products;

        public Homework09Logic()
        {
            _products = new List<Product>();
            LoadCSVFile();
        }

        private void LoadCSVFile()
        {
            using (var file = File.OpenText(FileName))
            {
                var allText = file.ReadToEnd().Split('\n').Skip(1);
                foreach (var item in allText)
                {
                    var data = item.Split(',');
                    var product = new Product
                    {
                        SKU = data[0],
                        Name = data[1],
                        Price = double.Parse(data[2])
                    };
                    _products.Add(product);
                    System.Console.WriteLine(item);
                }
            }
        }

        public void AddProductToCart(IProduct product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            throw new NotImplementedException();
        }
    }

    public class Product : IProduct
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}