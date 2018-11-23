using IHomework9.Lib.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework9.Lib
{
    public class Cart
    {
        public IEnumerable<IProduct> Products { get; set; }
    }
}
