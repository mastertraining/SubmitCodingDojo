using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace homework09.lib
{
    public class Homework09 : IHomework09
    {
        private const string FileName = @"product.csv";
        private List<Product> _products;
        private List<Product> _orderProducts;

        public Homework09()
        {
            _products = new List<Product>();
            _orderProducts = new List<Product>();
            LoadProducts();
        }

        public void AddProductToCart(IProduct product)
        {
            var isDataValid = product != null;
            if (!isDataValid) return;

            _orderProducts.Add(new Product(product));
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            return _products;
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            return _orderProducts;
        }

        private void LoadProducts()
        {
            using (var file = File.OpenText(FileName))
            {
                var textEachLine = file.ReadToEnd().Split('\n');
                foreach (var item in textEachLine.Skip(1))
                {
                    var data = item.Split(',');
                    var sku = data[0];
                    var name = data[1];
                    var price = int.Parse(data[2]);
                    _products.Add(new Product(sku, name, price));
                }
            }
        }
    }
}
