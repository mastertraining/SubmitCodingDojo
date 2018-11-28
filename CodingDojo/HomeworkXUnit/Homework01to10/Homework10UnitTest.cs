using FluentAssertions;
using Homework10;
using Homework10.Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace HomeworkXUnit
{
    public class Homework10UnitTest
    {
        IHomework10 IHW;
        public Homework10UnitTest() => IHW = new Homework10.Homework10();

        [Theory]
        [MemberData(nameof(ProductsInCartCase))]
        public void GetProductsInCartShouldWork(string[] productIdList, IList<IProduct> expected)
        {
            try
            {
                var products = IHW.GetAllProducts();
                foreach (var productId in productIdList)
                {
                    var order = productId.Split(",");
                    var product = products.FirstOrDefault(it => it.SKU == order[0]);
                    if (order.Count() > 1 && int.TryParse(order[1], out var amount))
                        for (int i = 0; i < amount; i++)
                        {
                            IHW.AddProductToCart(product);
                        }
                    else
                        IHW.AddProductToCart(product);
                }
                var result = IHW.GetProductsInCart();
                result.Should().BeEquivalentTo(expected);
                var HW10 = new Homework10.Homework10();
                result = HW10.GetProductsInCart();
                result.Should().BeEquivalentTo(new List<IProduct>());
                IHW.SaveCurrentState();
                HW10 = new Homework10.Homework10();
                result = HW10.GetProductsInCart();
                result.Should().BeEquivalentTo(expected);
            }
            finally
            {
                DeleteFiles();
            }
        }

        private void DeleteFiles()
        {
            var saveProductInCartPath = @"cart.json";
            File.Delete(saveProductInCartPath);
        }

        public static IEnumerable<object[]> ProductsInCartCase => new List<object[]>
        {
            new object[]{
                new string[] { "p01,1" , "p02,hello", "p01", "p05,5" },
                new List<IProduct>{
                    new Product { SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900 },
                    new Product { SKU = "p02", Name = "Apple Watch Series 4", Price = 14400 },
                    new Product { SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900 },
                    new Product { SKU = "p05", Name = "iPhone XS", Price = 39900 },
                    new Product { SKU = "p05", Name = "iPhone XS", Price = 39900 },
                    new Product { SKU = "p05", Name = "iPhone XS", Price = 39900 },
                    new Product { SKU = "p05", Name = "iPhone XS", Price = 39900 },
                    new Product { SKU = "p05", Name = "iPhone XS", Price = 39900 },
                }
            },
            new object[]{
                new string[] { "p01,2" , "p03,two", "p99,zero", "p05,3" },
                new List<IProduct>{
                    new Product { SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900 },
                    new Product { SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900 },
                    new Product { SKU = "p03", Name = "MacBook Pro with Touch Bar", Price = 47900 },
                    new Product { SKU = "p05", Name = "iPhone XS", Price = 39900 },
                    new Product { SKU = "p05", Name = "iPhone XS", Price = 39900 },
                    new Product { SKU = "p05", Name = "iPhone XS", Price = 39900 },
                }
            },
        };
    }
}
