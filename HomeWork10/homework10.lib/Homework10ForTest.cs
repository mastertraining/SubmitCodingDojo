using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace homework10.lib
{
    public class Homework10ForTest : IHomework10
    {
        private string _simulateData = $"SKU,Name,Price{Environment.NewLine}p01,iPad Pro 11-inch,23900{Environment.NewLine}p02,Apple Watch Series 4,14400{Environment.NewLine}p03,MacBook Pro with Touch Bar,47900{Environment.NewLine}p04,Apple TV 4K,8500{Environment.NewLine}p05,iPhone XS,39900{Environment.NewLine}p06,iPhone XS Max,43900{Environment.NewLine}p07,iPhone XR,29900{Environment.NewLine}p08,MacBook Air 13-inch,42900{Environment.NewLine}p09,Mac Mini 2018,27900";
        private string _simulateSavedCartFile = @"[{""SKU"": ""p01"",""Name"": ""iPad Pro 11-inch"",""Price"": 23900.0},{""SKU"": ""p02"",""Name"": ""Apple Watch Series 4"",""Price"": 14400.0}]";
        private IList<IProduct> _products;
        private IList<IProduct> _orderProducts;

        public Homework10ForTest(bool isLoadSavedCart)
        {
            _products = new List<IProduct>();
            _orderProducts = new List<IProduct>();
            LoadProducts();
            if (isLoadSavedCart) LoadSavedCart();
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
            _orderProducts = JSONConvertToCollection(_simulateSavedCartFile).ToList();
            const string downloadCompletMessage = "Download completed";
            return downloadCompletMessage;
        }

        public void SaveCurrentState()
        {
            throw new Exception("We do not test to write a file.");
        }

        private void LoadProducts()
        {
            var textEachLine = _simulateData.Split('\n');
            foreach (var item in textEachLine.Skip(1))
            {
                var data = item.Split(',');
                var sku = data[0];
                var name = data[1];
                var price = int.Parse(data[2]);
                _products.Add(new Product(sku, name, price));
            }
        }
    
        private IEnumerable<IProduct> JSONConvertToCollection(string text) => JsonConvert.DeserializeObject<IList<Product>>(text);
    }
}
