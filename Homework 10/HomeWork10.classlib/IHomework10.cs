using System.Collections.Generic;

public interface IHomework10
{
    IEnumerable<IProduct> GetAllProducts();
    void AddProductToCart(IProduct product);
    IEnumerable<IProduct> GetProductsInCart();
    void SaveCurrentState();
    string LoadSavedCart();
}