using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace homework10.lib
{
    public class Homework10 : IHomework10
    {
        private const string FileName = @"product.csv";
        private List<IProduct> _products;
        private List<IProduct> _orderProducts;

        public Homework10()
        {
            _products = new List<IProduct>();
            _orderProducts = new List<IProduct>();
            LoadProducts();
        }

        public void AddProductToCart(IProduct product)
        {
            var isDataValid = product != null;
            if (!isDataValid) return;

            _orderProducts.Add(product);
        }

        public IEnumerable<IProduct> GetAllProducts() => _products;

        public IEnumerable<IProduct> GetProductsInCart() => _orderProducts;

        public string LoadSavedCart()
        {
            throw new NotImplementedException();
        }

        public void SaveCurrentState()
        {
            throw new NotImplementedException();
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
