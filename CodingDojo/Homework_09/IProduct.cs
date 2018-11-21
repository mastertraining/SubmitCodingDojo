using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_09
{
    public interface IProduct
    {
        string SKU { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }
}
