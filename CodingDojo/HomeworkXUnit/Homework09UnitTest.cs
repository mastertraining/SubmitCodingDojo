using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Homework_09;
using System.Linq;

namespace HomeworkXUnit
{
    public class Homework09UnitTest
    {
        private IHomework09 IHW;
        public Homework09UnitTest() => IHW = new Homework09();

        [Theory]
        [MemberData(nameof(ProductsInCartCase))]
        public void GetProductsInCartShouldWork(string[] productIdList, IList<IProduct> expected)
        {
            var products = IHW.GetAllProducts();
            foreach (var productId in productIdList)
            {
               var product = products.FirstOrDefault(it => it.SKU == productId);
                IHW.AddProductToCart(product);
            }
            var result = IHW.GetProductsInCart();
            result.Should().BeEquivalentTo(expected);
        }

        public static IEnumerable<object[]> ProductsInCartCase => new List<object[]>
        {
            new object[]{
                new string[] { "p01" , "p02", "p01", "p05" },
                new List<IProduct>{
                    new Product { SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900 },
                    new Product { SKU = "p02", Name = "Apple Watch Series 4", Price = 14400 },
                    new Product { SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900 },
                    new Product { SKU = "p05", Name = "iPhone XS", Price = 39900 },
                }
            },
            new object[]{
                new string[] { "p01" , "p03", "p99", "p05" },
                new List<IProduct>{
                    new Product { SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900 },
                    new Product { SKU = "p03", Name = "MacBook Pro with Touch Bar", Price = 47900 },
                    new Product { SKU = "p05", Name = "iPhone XS", Price = 39900 },
                }
            },
        };
    }
}
