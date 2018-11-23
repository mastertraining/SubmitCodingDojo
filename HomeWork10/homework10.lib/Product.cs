using System;

namespace homework10.lib
{
    public class Product : IProduct
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string sku, string name, double price)
        {
            SKU = sku;
            Name = name;
            Price = price;
        }
    }
}
