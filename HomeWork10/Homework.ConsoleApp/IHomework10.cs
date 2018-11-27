using System.Collections.Generic;
using Homework.ConsoleApp;

namespace Homework.ConsoleApp
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
