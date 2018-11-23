using System;
using System.Collections.Generic;

namespace homework10.lib
{
    public interface IHomework10
    {
        IEnumerable<IProduct> GetAllProducts();
        void AddProductToCart(IProduct product);
        IEnumerable<IProduct> GetProductsInCart();
        void SaveCurrentState();
        string LoadSavedCart();
    }
}
