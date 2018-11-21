using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework_09
{
    public class Homework09 : IHomework09
    {
        private IList<IProduct> Cart;
        private IList<IProduct> Products;
        public Homework09()
        {
            Cart = new List<IProduct>();
            Products = GetAllProducts().ToList();
        }

        public void AddProductToCart(IProduct product)
        {
            if (product == null) return;

            product = Products.FirstOrDefault(it => it.SKU == product.SKU);
            if (product != null) Cart.Add(product);
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            var productFile = @"product.csv";
            if (!File.Exists(productFile)) return new List<IProduct>();

            using (var reader = File.OpenText(productFile))
            using (var csv = new CsvReader(reader))
            {
                return csv.GetRecords<Product>().ToList();
            }
        }

        public IEnumerable<IProduct> GetProductsInCart() => Cart;
    }
}
