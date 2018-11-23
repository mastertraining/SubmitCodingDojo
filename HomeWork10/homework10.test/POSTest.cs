using System;
using System.Collections.Generic;
using System.Linq;
using homework10.lib;
using Xunit;

namespace homework10.test
{
    public class POSTest
    {
        [Fact(DisplayName = "Get all product, Product should has 9 items")]
        public void POS_GetAllProduct()
        {
            var pos = new Homework10ForTest();
            var result = pos.GetAllProducts().ToList();
            var expectedProductCount = 9;
            Assert.Equal(expectedProductCount, result.Count);
        }

        [Theory(DisplayName = "Add product to cart should be success")]
        [InlineData("p01")]
        [InlineData("p02")]
        [InlineData("p03")]
        [InlineData("p04")]
        [InlineData("p05")]
        [InlineData("p06")]
        [InlineData("p07")]
        [InlineData("p08")]
        [InlineData("p09")]
        public void POS_AddProductToCart_OnceTime_Success(string productId)
        {
            var pos = new Homework10ForTest();
            var productInCartBeforeAdd = pos.GetProductsInCart().ToList();
            Assert.False(productInCartBeforeAdd.Any());

            var products = pos.GetAllProducts().ToList();
            var product = products.FirstOrDefault(it => it.SKU.Equals(productId, StringComparison.CurrentCultureIgnoreCase));
            pos.AddProductToCart(product);

            var result = pos.GetProductsInCart().ToList();
            var expectedProductCount = 1;
            Assert.Equal(expectedProductCount, result.Count);
        }

        [Theory(DisplayName = "Add product to cart should be success")]
        [InlineData("p01,p02,p03", 3)]
        [InlineData("p04,p05,p06,p07,p08,p09", 6)]
        [InlineData("p01,p02,p03,p04,p05,p06,p07,p08,p09", 9)]
        public void POS_AddProductToCart_ManyTime_Success(string productIdList, int expectedProductCount)
        {
            var pos = new Homework10ForTest();
            var productInCartBeforeAdd = pos.GetProductsInCart().ToList();
            Assert.False(productInCartBeforeAdd.Any());

            var productIds = productIdList.Split(",");

            var products = pos.GetAllProducts().ToList();
            var productShouldAddToCart = products.Where(it => productIds.Contains(it.SKU));
            foreach (var item in productShouldAddToCart) pos.AddProductToCart(item);

            var result = pos.GetProductsInCart().ToList();
            Assert.Equal(expectedProductCount, result.Count);
        }

        [Theory(DisplayName = "Add product to cart should be fail")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        [InlineData("product-id-does-not-exist")]
        public void POS_AddProductToCart_Fail(string productId)
        {
            var pos = new Homework10ForTest();
            var productInCartBeforeAdd = pos.GetProductsInCart().ToList();
            Assert.False(productInCartBeforeAdd.Any());

            var products = pos.GetAllProducts().ToList();
            var product = products.FirstOrDefault(it => it.SKU.Equals(productId, StringComparison.CurrentCultureIgnoreCase));
            pos.AddProductToCart(product);

            var result = pos.GetProductsInCart().ToList();
            Assert.False(result.Any());
        }
    }
}
