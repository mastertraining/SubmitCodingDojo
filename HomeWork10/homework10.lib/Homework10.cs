using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace homework10.lib
{
    public class Homework10 : IHomework10
    {
        private const string ProductFileName = @"product.csv";
        private const string SavedCartFileName = @"cart.json";
        private IList<IProduct> _products;
        private IList<IProduct> _orderProducts;

        public Homework10()
        {
            _products = new List<IProduct>();
            _orderProducts = new List<IProduct>();
            LoadProducts();
            LoadSavedCart();
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
            if (!File.Exists(SavedCartFileName)) return "Can not found any file";
            using (var file = File.OpenText(SavedCartFileName))
            {
                var text = file.ReadToEnd();
                _orderProducts = JSONConvertToCollection(text).ToList();
                const string downloadCompletMessage = "Download completed";
                return downloadCompletMessage;
            }
        }

        public void SaveCurrentState()
        {
            var cartData = JsonConvert.SerializeObject(_orderProducts);
            File.WriteAllText(SavedCartFileName, cartData);
        }

        private void LoadProducts()
        {
            using (var file = File.OpenText(ProductFileName))
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

        private IEnumerable<IProduct> JSONConvertToCollection(string text) => JsonConvert.DeserializeObject<IList<Product>>(text);

    }
}
