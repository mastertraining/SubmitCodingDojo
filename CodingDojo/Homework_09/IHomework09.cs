using System;
using System.Collections.Generic;

namespace Homework_09
{
    public interface IHomework09
    {
        IEnumerable<IProduct> GetAllProducts();
        void AddProductToCart(IProduct product);
        IEnumerable<IProduct> GetProductsInCart();
    }
}
