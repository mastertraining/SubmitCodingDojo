using System;
using System.Collections.Generic;

namespace homework09
{
    public class ProductLogic : IHomework09
    {
        public List<Product> productsList { get; set; }
        public List<Product> productsCart { get; set; }
        public void setCart()
        {
            productsCart = new List<Product>();
        }
        public void AddProductToCart(IProduct product)
        {
            productsCart.Add(new Product
            {
                SKU = product.SKU,
                Name = product.Name,
                Price = product.Price
            });
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            return productsCart;
        }
    }
}
