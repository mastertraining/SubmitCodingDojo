using System;

namespace homework10.lib
{
    public interface IProduct
    {
        string SKU { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }
}
