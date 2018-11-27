using System.Collections.Generic;

public interface IHomework09
{
    IEnumerable<IProduct> GetAllProducts();
    void AddProductIoCart(IProduct product);
    IEnumerable<IProduct> GetProductsInCart();
}