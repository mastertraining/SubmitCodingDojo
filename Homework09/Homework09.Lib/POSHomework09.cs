using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework09.Lib {
    public class POSHomework09 : IHomework09 {
        public List<Product> Cart { get; set; }
        public IEnumerable<IProduct> GetAllProducts () {

            var productList = new List<Product> ();
            using (StreamReader sr = new StreamReader (@"product.csv")) {
                while (!sr.EndOfStream) {
                    String getProduct = sr.ReadToEnd ();
                    var newListProduct = getProduct.Split (',');
                    Double.TryParse (newListProduct[2], out double priceProduct);
                    var addProduct = new Product ();
                    addProduct.SKU = newListProduct[0];
                    addProduct.Name = newListProduct[1];
                    addProduct.Price = priceProduct;

                    productList.Add (addProduct);
                }
            }

            return productList;
        }
        public void AddProductToCart (IProduct product) {
            Cart.Add (new Product {
                SKU = product.SKU,
                    Name = product.Name,
                    Price = product.Price
            });
        }
        public IEnumerable<IProduct> GetProductsInCart () => Cart;
    }
}