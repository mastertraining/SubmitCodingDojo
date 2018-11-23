using IHomework9.Lib.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework9.Lib
{
    public class Product : IProduct
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
