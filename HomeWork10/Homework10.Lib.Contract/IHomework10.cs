using System;
using System.Collections.Generic;

namespace Homework10.Lib.Contract
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
