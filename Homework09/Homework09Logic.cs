using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homework09
{
    class Homework09Logic : IHomework09
    {
        private const string FileName = @"product.csv";  
        private List<Product> _products; 
        private List<Product> _addProductCart { get; set; } 
        public Homework09Logic() 
        {
            _products = new List<Product>(); 
            LoadCSVFile();
        }

        private void LoadCSVFile()  
        {
            using (var file = File.OpenText(FileName)) 
            {
                
                var allText = file.ReadToEnd().Split('\n').Skip(1);
                foreach (var item in allText)
                {
                    var data = item.Split(','); 
                    var product = new Product
                    {
                        SKU = data[0],
                        Name = data[1],
                        Price = double.Parse(data[2])
                    };
                    _products.Add(product); 
                    
                }
            }
        }

        public void AddProductToCart(IProduct product)
        {
            var collect = new Product 
            {
                SKU = product.SKU, 
                Name = product.Name,
                Price = product.Price
            };
            _addProductCart.Add(collect); 
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            return _products;
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            return _addProductCart;
        }
    }

    public class Product : IProduct
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}