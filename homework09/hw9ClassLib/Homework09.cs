using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hw9ClassLib
{
    public class Homework09 : IHomework09
    {
        private List<IProduct> _Cart = new List<IProduct>();
        private List<Product> _Products = new List<Product>();
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
                        _Products.Add(new Product
                        {
                            SKU = values[0],
                            Name = values[1],
                            Price = priceDouble,
                        });
                    }
                }
            }
            return _Products;
        }
        public void AddProductToCart(IProduct product)
        {
            _Cart.Add(product);
        }
        public IEnumerable<IProduct> GetProductsInCart()
        {
            return _Cart;
        }
    }
}
