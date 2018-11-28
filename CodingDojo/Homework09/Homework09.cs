using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homework09
{
    public class Homework09 : IHomework09
    {
        private IList<IProduct> cart;
        private IList<IProduct> products;
        public Homework09()
        {
            cart = new List<IProduct>();
            products = GetAllProducts().ToList();
        }

        public void AddProductToCart(IProduct product)
        {
            if (product == null) return;
            product = products.FirstOrDefault(it => it.SKU == product.SKU);
            if (product != null) cart.Add(product);
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

        public IEnumerable<IProduct> GetProductsInCart() => cart;
    }
}
