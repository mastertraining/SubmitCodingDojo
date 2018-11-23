using System;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Collections.Generic;

namespace Homework9
{
    class Program: IHomework09
    {
        List<IProduct> products { get; set; }
        string filePath { get; set; }

        static void Main(string[] args)
        {
/*            IEnumerable<int> result = from value in Enumerable.Range(0, 2)
                                      select value;
            foreach (int value in result)
            {
                Console.WriteLine(value);
            }
*/
            Program prm = new Program();
            prm.getData();
        }

        void getData()
        {
            filePath = @"product.csv";
            List<string> result = new List<string>();
            string value;
            using (TextReader fileReader = File.OpenText(filePath))
            {
                var csv = new CsvReader(fileReader);
                csv.Configuration.HasHeaderRecord = false;
                while (csv.Read())
                {
                    for (int i  = 0; csv.TryGetField<string>(i, out value); i++)
                    {
                        Console.Write(value);
                    }
                    Console.WriteLine();
                }
            }

        }

        public void AddProductToCart(IProduct product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetProductsInCart()
        {
            throw new NotImplementedException();
        }
    }
}
