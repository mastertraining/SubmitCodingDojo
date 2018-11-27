using System;
using System.IO;
using CsvHelper;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;

public class Homework10: IHomework10
{
    public  List<IProduct> cart { get; set; }
    private List<IProduct> order { get; set; }
    private string         _filePath { get; set; }
    private List<IProduct> _allProducts { get; set; }

    public Homework10()
    {
        _filePath    = "";
        _allProducts = new List<IProduct>();
        order        = new List<IProduct>();
        cart         = new List<IProduct>();
    }

    public void AddProductToCart(IProduct product)
    {
        cart.Add(product);
    }

    public IEnumerable<IProduct> GetAllProducts()
    {
        _filePath = @"../classlib/product.csv";
        Tuple<string, string, double> row;
        using (TextReader fileReader = File.OpenText(_filePath))
        {
            fileReader.ReadLine(); // Ignored header of csv file.
            var csv = new CsvReader(fileReader);
            while (csv.Read())
            {
                row = Tuple.Create(csv.GetField<string>(0), csv.GetField<string>(1), csv.GetField<Double>(2));
                _allProducts.Add(new Product()
                {
                    SKU   = row.Item1,
                    Name  = row.Item2,
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

    public string LoadSavedCart()
    {
        _filePath = @"../classlib/cart.json";
        ILoadSaved data;
        using (StreamReader reader = new StreamReader(_filePath))
        {
            string json = reader.ReadToEnd();
            data = JsonConvert.DeserializeObject<ILoadSaved>(json);
            this.cart = data.ordering;
        }
        return data.ToString();
    }

    public void SaveCurrentState()
    {
        _filePath = @"../classlib/cart.json";
        using (StreamWriter writer = new StreamWriter(_filePath))
        {
            StringBuilder JsonBuilder = new StringBuilder();
            JsonBuilder.Append("{\"ordering:\"")
                       .Append(JsonConvert.SerializeObject(cart, Formatting.Indented))
                       .Append("}");
            writer.Write(JsonBuilder.ToString());
        }
    }
}