using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeWork10.classlib
{
    public class HomeWork10ClassLib : IHomework10
    {
        public List<IProduct> listProduct { get; set; }
        public List<IProduct> listProduct2 { get; set; }
        public List<IProduct> listCart { get; set; }
        public int amount { get; set; }
        public double balance { get; set; }
        public Dictionary<string, int> countProduct { get; set; }

        public void setDefaultCart()
        {
            listCart = new List<IProduct>();
            countProduct = new Dictionary<string, int>();
            countProduct.Add("p01", 0);
            countProduct.Add("p02", 0);
            countProduct.Add("p03", 0);
            countProduct.Add("p04", 0);
            countProduct.Add("p05", 0);
            countProduct.Add("p06", 0);
            countProduct.Add("p07", 0);
            countProduct.Add("p08", 0);
            countProduct.Add("p09", 0);
            amount = 0;
            balance = 0;
        }

        public void AddProductToCart(IProduct product)
        {
            var checkDuplicateProduct = listCart.FirstOrDefault(it => it.SKU == product.SKU);
            if (checkDuplicateProduct != null)
            {
                countProduct[product.SKU] += amount;
            }
            else
            {
                listCart.Add(product);
                countProduct[product.SKU] = amount;
            }
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            var FilePath = @"product.csv";
            listProduct = new List<IProduct>();
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

                        listProduct.Add(new Product()
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
        
        public string LoadSavedCart()
        {
            throw new NotImplementedException();
        }

        public void SaveCurrentState()
        {
            throw new NotImplementedException();
        }
    }
}
