using System.Collections.Generic;
using Homework.ConsoleApp;

public interface IHomework09
{
    IEnumerable<IProduct> GetAllProducts();
    void AddProductToCart(IProduct product);
    IEnumerable<IProduct> GetProductsInCart();
}