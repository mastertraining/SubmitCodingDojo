using System;
using System.Collections.Generic;

namespace Homework09
{
    class Homework09Logic : IHomework09
    {
        private const string FileName = @"product.csv";
        
        public void AddProductToCart(IProduct product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            throw new NotImplementedException();
        }
    }

    class Homework09LogicIProduct : IProduct
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}