using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace HomeWork10.classlib
{
    public class HomeWork10ClassLib : IHomework10
    {
        public List<IProduct> listProduct { get; set; }
        public List<IProduct> listCart { get; set; }
        public int amount { get; set; }
        public double balance { get; set; }
        public Dictionary<string, int> countProduct { get; set; }
        public string filePathCartJason = @"cart.json";
        public string filePathAmountJason = @"amout.json";
        public string fileReadJson { get; set; }
        public string fileReadAMountJson { get; set; }

        public void setDefaultCart()
        {
            listCart = new List<IProduct>();
            amount = 0;
            balance = 0;
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

        public void Load()
        {
            listCart = new List<IProduct>();
            if (File.Exists(filePathAmountJason))
            {
                using (var file = File.OpenText(filePathAmountJason))
                {
                    fileReadAMountJson = file.ReadToEnd();
                }
                var amountJson = JsonConvert.DeserializeObject<Dictionary<string, int>>(fileReadAMountJson);
                countProduct = amountJson;
            }

            var loadJson = LoadSavedCart();
            if (loadJson != "none")
            {
                var productJson = JsonConvert.DeserializeObject<List<Product>>(loadJson);
                for (int i = 0; i < productJson.Count; i++)
                {
                    listCart.Add(productJson[i]);
                }
            }

        }

        public string LoadSavedCart()
        {
            var jsonData = "none";
            if (File.Exists(filePathCartJason))
            {
                using (var file = File.OpenText(filePathCartJason))
                {
                    fileReadJson = file.ReadToEnd();

                }
                var productJson = JsonConvert.DeserializeObject<List<Product>>(fileReadJson);
                jsonData = JsonConvert.SerializeObject(productJson, Formatting.Indented);
            }
            return jsonData;
        }

        public void SaveCurrentState()
        {
            using (var jsonWriter = File.CreateText(filePathCartJason))
            {
                var productsJson = JsonConvert.SerializeObject(listCart, Formatting.Indented);
                jsonWriter.WriteLine(productsJson);
            }

            using (var jsonWriter = File.CreateText(filePathAmountJason))
            {
                var productsJson = JsonConvert.SerializeObject(countProduct, Formatting.Indented);
                jsonWriter.WriteLine(productsJson);
            }
        }
    }
}
