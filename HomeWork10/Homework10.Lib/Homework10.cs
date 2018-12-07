using CsvHelper;
using Homework10.Lib.Contract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework10.Lib
{
    public class Homework10 : IHomework10
    {
        private const string PRODUCT_PATH = @"product.csv";
        private const string CART_PATH = @"cart.json";
        private const string MOCK_CSV_FILE_TEXT = @"SKU,Name,Price
p01,iPad Pro 11-inch,23900
p02,Apple Watch Series 4,14400
p03,MacBook Pro with Touch Bar,47900
p04,Apple TV 4K,8500
p05,iPhone XS,39900
p06,iPhone XS Max,43900
p07,iPhone XR,29900
p08,MacBook Air 13-inch,42900
p09,Mac Mini 2018,27900";

        private Cart cart;
        private IEnumerable<IProduct> products;

        public string NotFoundProductText { get { return "Not found product"; } }
        public string SaveStateText { get { return "Current state had been saved!"; } }

        public Homework10()
        {
            cart = new Cart(new List<Product>());
            products = GetAllProducts();
        }

        public void CreateMockProductIfFileNotExists()
        {
            File.WriteAllText(PRODUCT_PATH, MOCK_CSV_FILE_TEXT);
        }

        public bool AddProductByString(string inputString)
        {
            var parameter = inputString.Split(",", StringSplitOptions.RemoveEmptyEntries);
            var product = products.FirstOrDefault(it => it.SKU == parameter[0]);
            if (product != null)
            {
                var addCount = parameter.Count() == 2 && !string.IsNullOrEmpty(parameter[1]) && int.TryParse(parameter[1], out var count) ? count : 1;
                for (int i = 0; i < addCount; i++)
                {
                    AddProductToCart(product);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetPrintString()
        {
            StringBuilder stringToPrint = new StringBuilder();
            stringToPrint.AppendLine();
            stringToPrint.AppendLine("Products in your cart are");

            if (cart.Products == null || cart.Products.Count() == 0)
            {
                stringToPrint.AppendLine("none");
            }
            else
            {
                var ItemToPrint = GetProductsInCart().GroupBy(it => it.Name);
                foreach (var item in ItemToPrint.Select((value, i) => new { i, value }))
                {
                    stringToPrint.Append(item.i + 1).Append('.')
                        .AppendFormat("{0,-40}", item.value.Key)
                        .AppendFormat("({0}) ", item.value.Count())
                        .Append(item.value.FirstOrDefault().Price.ToString("###,###,###.00"))
                        .AppendLine();
                }
            }

            stringToPrint.AppendLine(new string('-', 3))
                .Append("Total amount: ")
                .Append(cart.Products.Sum(it => it.Price).ToString("###,###,##0.00"))
                .AppendLine(" baht")
                .Append("Please input a product key: ");

            return stringToPrint.ToString();
        }

        public void AddProductToCart(IProduct product)
        {
            var products = cart.Products.ToList();
            products.Add(product);
            cart.Products = products;
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            IEnumerable<Product> products;
            if (File.Exists(PRODUCT_PATH))
            {
                using (TextReader reader = File.OpenText(PRODUCT_PATH))
                {
                    try
                    {
                        var csv = new CsvReader(reader);
                        products = csv.GetRecords<Product>().ToList();
                    }
                    catch (Exception e)
                    {
                        products = new List<Product>();
                    }

                }
                return products;
            }
            else
            {
                return new List<Product>();
            }
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            return cart.Products;
        }

        public void SaveCurrentState()
        {
            var json = JsonConvert.SerializeObject(cart);
            File.WriteAllText(CART_PATH, json);
        }

        public string LoadSavedCart()
        {
            if (File.Exists(CART_PATH))
            {
                using (var reader = File.OpenText(CART_PATH))
                {
                    try
                    {
                        var settings = new JsonSerializerSettings()
                        {
                            TypeNameHandling = TypeNameHandling.All
                        };
                        var txt = reader.ReadToEnd();
                        cart = JsonConvert.DeserializeObject<Cart>(txt, settings);
                    }
                    catch (Exception e)
                    {
                    }

                }
                return GetPrintString();
            }
            else
            {
                return GetPrintString();
            }
        }
    }
}
