using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Homework_09
{
    public class Homework09 : IHomework09
    {
        public void AddProductToCart(IProduct product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            var productFile = @"product.csv";
            var b = File.Exists(productFile);
            using (var reader = File.OpenText(productFile))
            {
                using (var csv = new CsvReader(reader))
                {
                    var records = csv.GetRecords<Product>();
                }
            }
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            throw new NotImplementedException();
        }
    }
}
