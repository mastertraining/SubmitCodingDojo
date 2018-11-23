
using System.Collections.Generic;

public interface IHomework09
{
    IEnumerable<IProduct> GetAllProducts();
    void AddProductToCart(IProduct product);
    IEnumerable<IProduct> GetProductsInCart();
}

public interface IProduct
{
    string SKU { get;set; }
    string Name { get;set; }
    double Price { get;set; }
}