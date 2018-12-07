using CsvHelper;
using IHomework9.Lib.Contract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework9.Lib
{
    public class Homework09 : IHomework09
    {
        private const string PATH = @"product.csv";
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

        public Homework09()
        {
            cart = new Cart { Products = new List<Product>() };
            products = GetAllProducts();
        }

        public void CreateMockProductIfFileNotExists()
        {
            File.WriteAllText(PATH, MOCK_CSV_FILE_TEXT);
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
            if (File.Exists(PATH))
            {
                using (TextReader reader = File.OpenText(PATH))
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

        public bool AddProductByKey(string key)
        {
            var product = products.FirstOrDefault(it => it.SKU == key);
            if (product != null)
            {
                AddProductToCart(product);
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
            stringToPrint.AppendLine("Products in your cart are");

            if (cart.Products == null || cart.Products.Count() == 0)
            {
                stringToPrint.AppendLine("none");
            }
            else
            {
                foreach (var item in cart.Products.Select((value, i) => new { i, value }))
                {
                    stringToPrint.Append(item.i + 1).Append('.')
                        .AppendFormat("{0,-40}", item.value.Name)
                        .Append(item.value.Price.ToString("###,###,###.00"))
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
    }
}
