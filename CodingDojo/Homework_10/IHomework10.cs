using Homework_10.Model;
using System.Collections.Generic;

namespace Homework_10
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
