using System;

namespace homework09.lib
{
    public interface IProduct
    {
        string SKU { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }

}
