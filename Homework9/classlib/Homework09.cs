using System;
using System.IO;
using CsvHelper;
using System.Collections.Generic;

public class Homework09: IHomework09
{
    public List<IProduct> cart;
    private List<IProduct> _allProducts;
    private string _filePath;

    public Homework09()
    {
        cart         = new List<IProduct>();
        _filePath    = @"./../classlib/products.csv";
        _allProducts = new List<IProduct>();
    }

    public void AddProductIoCart(IProduct product)
    {
        cart.Add(product);
    }

    public IEnumerable<IProduct> GetAllProducts()
    {
        using (StreamReader fileReader = new StreamReader(File.OpenRead(_filePath)))
        {
            fileReader.ReadLine(); // Ignored header of Csv
            var csv = new CsvReader(fileReader);
            Tuple<string, string, double> row;
            while (csv.Read())
            {
                row = Tuple.Create(csv.GetField<string>(0), csv.GetField<string>(1), csv.GetField<double>(2));
                _allProducts.Add(new Product()
                {
                    SKU = row.Item1,
                    Name = row.Item2,
                    Price = row.Item3
                });
            }
        }
        return _allProducts;
    }

    public IEnumerable<IProduct> GetProductsInCart()
    {
        return cart;
    }
}
