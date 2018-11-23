using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace homework09.lib
{
    public class Homework09ForTest : IHomework09
    {
        private string _simulateData = $"SKU,Name,Price{Environment.NewLine}p01,iPad Pro 11-inch,23900{Environment.NewLine}p02,Apple Watch Series 4,14400{Environment.NewLine}p03,MacBook Pro with Touch Bar,47900{Environment.NewLine}p04,Apple TV 4K,8500{Environment.NewLine}p05,iPhone XS,39900{Environment.NewLine}p06,iPhone XS Max,43900{Environment.NewLine}p07,iPhone XR,29900{Environment.NewLine}p08,MacBook Air 13-inch,42900{Environment.NewLine}p09,Mac Mini 2018,27900";
        private List<Product> _products;
        private List<Product> _orderProducts;

        public Homework09ForTest()
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
    }
}
