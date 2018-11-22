using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeWork9.classlib
{
    public class HomeWork9ClassLib : IHomework09
    {
        public List<Product> listProduct { get; set; }
        public List<Product> listCart { get; set; }

        public void setDefaultCart()
        {
            listCart = new List<Product>();
        }

        public void AddProductToCart(IProduct product)
        {
            listCart.Add(new Product
            {
                SKU = product.SKU,
                Name = product.Name,
                Price = product.Price
            });
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            var FilePath = @"product.csv";
            listProduct = new List<Product>();
            using (var reader = new StreamReader(FilePath))
            {
                while (!reader.EndOfStream)
                {
                    var product = new Product();
                    var getReadCsv = reader.ReadLine();
                    var dataFromSv = getReadCsv.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    foreach (var data in dataFromSv)
                    {
                        var listData = data.Split(',').ToList();
                        Double.TryParse(listData[2], out double priceProduct);
                        listProduct.Add(new Product
                        {
                            SKU = listData[0],
                            Name = listData[1],
                            Price = priceProduct
                        });
                    }
                }
            }
            return listProduct;
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            return listCart;
        }
    }
}
