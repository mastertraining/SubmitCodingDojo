using System.Collections.Generic;

namespace Homework10
{
    public interface IHomework10
    {
        IEnumerable<IProduct> GetAllProducts();
        void AddProductToCart(IProduct product);
        IEnumerable<IProduct> GetProductsInCart();
        void SaveCurrentState();
        string LoadSavedCart();
    }

    public interface IProduct
    {
        string SKU { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }
}
