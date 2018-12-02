using System.Collections.Generic;

namespace Homework09.Lib {
    public interface IHomework09 {
        IEnumerable<IProduct> GetAllProducts ();
        void AddProductToCart (IProduct product);
        IEnumerable<IProduct> GetProductsInCart ();
    }
}