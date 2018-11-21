using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_09
{
    public class Product : IProduct
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
