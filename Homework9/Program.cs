using System;
using System.Collections.Generic;

namespace Homework9
{
    class Program: IHomework09
    {
        List<IProduct> products { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

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
}
