using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10.Lib.Contract
{
    public interface IProduct
    {
        string SKU { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }
}
