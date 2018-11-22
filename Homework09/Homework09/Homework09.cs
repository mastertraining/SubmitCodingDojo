using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homework09
{
    public class Homework09 : IHomework09
    {
        private string path { get; set; }
        private IList<IProduct> myCart { get; set; }
        private IEnumerable<IProduct> allProduct { get; set; }

        public Homework09()
        {
            path = @"product.csv";
            myCart = new List<IProduct>();
            allProduct = GetAllProducts();
        }

        public void GetProductById(string productid)
        {
            var selecdProduct = allProduct.FirstOrDefault(it => it.SKU == productid);
            AddProductToCart(selecdProduct);
        }

        public void AddProductToCart(IProduct product)
        {
            if (product != null) myCart.Add(product);
            else Console.WriteLine("Your ProductId is invalid !");
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            using (var reader = File.OpenText(path))
            using (var csv = new CsvReader(reader))
            {
                var records = csv.GetRecords<Product>().ToList();
                return records;
            }
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            return myCart;
        }

        public string GetCartSummary()
        {
            var sum = myCart.Select(it => it.Price).Sum();
            return String.Format("{0:#,##0.00}", sum);
        }
    }

    public class Product : IProduct
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
