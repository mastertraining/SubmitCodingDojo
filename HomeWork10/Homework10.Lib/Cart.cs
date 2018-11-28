using Homework10.Lib.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10.Lib
{
    public class Cart
    {
        public Cart(IEnumerable<Product> products)
        {
            Products = products;
        }

        public IEnumerable<IProduct> Products { get; set; }
    }
}
