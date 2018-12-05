using System;
using System.Collections.Generic;

namespace homework09.lib
{
    public interface IHomework09
    {
        IEnumerable<IProduct> GetAllProducts();
        void AddProductToCart(IProduct product);
        IEnumerable<IProduct> GetProductsInCart();
    }

}
