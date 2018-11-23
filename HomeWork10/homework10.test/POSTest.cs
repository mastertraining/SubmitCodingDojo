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
            var isLoadSavedCartFile = false;
            var pos = new Homework10ForTest(isLoadSavedCartFile);
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
            var isLoadSavedCartFile = false;
            var pos = new Homework10ForTest(isLoadSavedCartFile);
            var productInCartBeforeAdd = pos.GetProductsInCart().ToList();
            Assert.False(productInCartBeforeAdd.Any());

            var products = pos.GetAllProducts().ToList();
            var product = products.FirstOrDefault(it => it.SKU.Equals(productId, StringComparison.CurrentCultureIgnoreCase));
            pos.AddProductToCart(product);

            var result = pos.GetProductsInCart().ToList();
            var expectedProductCount = 1;
            Assert.Equal(expectedProductCount, result.Count);
        }

        [Theory(DisplayName = "Add product to cart once after load saved cart file should be success")]
        [InlineData("p01")]
        [InlineData("p02")]
        [InlineData("p03")]
        [InlineData("p04")]
        [InlineData("p05")]
        [InlineData("p06")]
        [InlineData("p07")]
        [InlineData("p08")]
        [InlineData("p09")]
        public void POS_AddProductToCart_OnceTime_AfterLoadSavedCart_Success(string productId)
        {
            var isLoadSavedCartFile = true;
            var pos = new Homework10ForTest(isLoadSavedCartFile);
            var productInCartBeforeAdd = pos.GetProductsInCart().ToList();
            var expectedProductCountBeforeAddToCart = 2;
            Assert.Equal(expectedProductCountBeforeAddToCart, productInCartBeforeAdd.Count);

            var products = pos.GetAllProducts().ToList();
            var product = products.FirstOrDefault(it => it.SKU.Equals(productId, StringComparison.CurrentCultureIgnoreCase));
            pos.AddProductToCart(product);

            var result = pos.GetProductsInCart().ToList();
            var expectedProductCount = 3;
            Assert.Equal(expectedProductCount, result.Count);
        }

        [Theory(DisplayName = "Add many products to cart should be success")]
        [InlineData("p01,3", 3)]
        [InlineData("p04,4", 4)]
        [InlineData("p01,hello world", 1)]
        [InlineData("p01,", 1)]
        public void POS_AddProductToCart_ManyTime_Success(string input, int expectedProductCount)
        {
            var isLoadSavedCartFile = false;
            var pos = new Homework10ForTest(isLoadSavedCartFile);
            var productInCartBeforeAdd = pos.GetProductsInCart().ToList();
            Assert.False(productInCartBeforeAdd.Any());

            var inputSplited = input.Split(",");
            var productId = inputSplited.FirstOrDefault();
            var products = pos.GetAllProducts().ToList();
            var product = products.FirstOrDefault(it => it.SKU.Equals(productId, StringComparison.CurrentCultureIgnoreCase));

            const int MinimumOrderProductAmount = 1;
            int.TryParse(inputSplited.LastOrDefault(), out int orderProductAmount);
            if (orderProductAmount < MinimumOrderProductAmount) orderProductAmount = MinimumOrderProductAmount;
            for (int i = 0; i < orderProductAmount; i++)
            {
                pos.AddProductToCart(product);
            }

            var result = pos.GetProductsInCart().ToList();
            Assert.Equal(expectedProductCount, result.Count);
        }


        [Theory(DisplayName = "Add many products to cart after load saved cart file should be success")]
        [InlineData("p01,3", 5)]
        [InlineData("p04,4", 6)]
        [InlineData("p01,hello world", 3)]
        [InlineData("p01,", 3)]
        public void POS_AddProductToCart_ManyTime_AfterLoadSavedCart_Success(string input, int expectedProductCount)
        {
            var isLoadSavedCartFile = true;
            var pos = new Homework10ForTest(isLoadSavedCartFile);
            var productInCartBeforeAdd = pos.GetProductsInCart().ToList();
            var expectedProductCountBeforeAddToCart = 2;
            Assert.Equal(expectedProductCountBeforeAddToCart, productInCartBeforeAdd.Count);

            var inputSplited = input.Split(",");
            var productId = inputSplited.FirstOrDefault();
            var products = pos.GetAllProducts().ToList();
            var product = products.FirstOrDefault(it => it.SKU.Equals(productId, StringComparison.CurrentCultureIgnoreCase));

            const int MinimumOrderProductAmount = 1;
            int.TryParse(inputSplited.LastOrDefault(), out int orderProductAmount);
            if (orderProductAmount < MinimumOrderProductAmount) orderProductAmount = MinimumOrderProductAmount;
            for (int i = 0; i < orderProductAmount; i++)
            {
                pos.AddProductToCart(product);
            }

            var result = pos.GetProductsInCart().ToList();
            Assert.Equal(expectedProductCount, result.Count);
        }

        [Theory(DisplayName = "Add product to cart but wrong input should be fail")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        [InlineData("product-id-does-not-exist")]
        public void POS_AddProductToCart_Fail(string productId)
        {
            var isLoadSavedCartFile = false;
            var pos = new Homework10ForTest(isLoadSavedCartFile);
            var productInCartBeforeAdd = pos.GetProductsInCart().ToList();
            Assert.False(productInCartBeforeAdd.Any());

            var products = pos.GetAllProducts().ToList();
            var product = products.FirstOrDefault(it => it.SKU.Equals(productId, StringComparison.CurrentCultureIgnoreCase));
            pos.AddProductToCart(product);

            var result = pos.GetProductsInCart().ToList();
            Assert.False(result.Any());
        }

        [Fact(DisplayName = "Add product to cart with empty product(null) should be fail")]
        public void POS_AddProductNullToCart_ShouldBe_Fail()
        {
            var isLoadSavedCartFile = false;
            var pos = new Homework10ForTest(isLoadSavedCartFile);
            var productInCartBeforeAdd = pos.GetProductsInCart().ToList();
            Assert.False(productInCartBeforeAdd.Any());

            pos.AddProductToCart(null);
            var result = pos.GetProductsInCart().ToList();
            Assert.False(result.Any());
        }
    }
}
