using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hw9ClassLib
{
    public class Homework09 : IHomework09
    {
        private List<IProduct> _cart = new List<IProduct>();
        private List<IProduct> _products = new List<IProduct>();
        private string _path = @"..\hw9Console\product.csv";
        public IEnumerable<IProduct> GetAllProducts()
        {
            using (var reader = new StreamReader(_path))
            {
                while (!reader.EndOfStream)
                {
                    var read = reader.ReadLine();
                    var splitLine = read.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    foreach (var item in splitLine)
                    {
                        var values = item.Split(',');
                        Double.TryParse(values[2], out double priceDouble);
                        _products.Add(new Product
                        {
                            SKU = values[0],
                            Name = values[1],
                            Price = priceDouble,
                        });
                    }
                }
            }

            return _products;
        }
        public void AddProductToCart(IProduct product)
        {
            _cart.Add(product);
        }
        public IEnumerable<IProduct> GetProductsInCart()
        {
            return _cart;
        }
    }
}
