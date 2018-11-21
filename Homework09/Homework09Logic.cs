using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homework09
{
    class Homework09Logic : IHomework09
    {
        private const string FileName = @"product.csv";  //เก็บไฟลล์ .csv ไว้ในตัวแปร
        private List<Product> _products; //ประกาศตัวแปรที่โดนaddค่า ในclass เพื่อที่methodอื่นจะได้เรียกใช้ได้

        public Homework09Logic() //สร้าง constractor(ทุกครั้งที่เปิดอันนี้จะทำงาน ต้องชื่อเดีบวกับคลาส)
        {
            _products = new List<Product>(); // ประกาศ obj.เพื่อให้รู้ว่าจะเก็บของไว้ที่ไหน
            LoadCSVFile();
        }

        private void LoadCSVFile() //อ่านไฟลล์ csv
        {
            using (var file = File.OpenText(FileName)) //เปิดไฟลล์จากไหน
            {
                //อ่านตั้งแต่ต้นจนจบ(ได้textยาวๆต่อกัน) split ออกได้เป็น[] skip[1]ออก
                var allText = file.ReadToEnd().Split('\n').Skip(1); 
                foreach (var item in allText)
                {
                    var data = item.Split(','); //[]แต่ละก่อนมา split,ออก
                    var product = new Product //สร้าง obj ใหม่เพื่อ addค่าให้กับของในนั้น
                    {
                        SKU = data[0],
                        Name = data[1],
                        Price = double.Parse(data[2])
                    };
                    _products.Add(product); //เก็บค่าที่ add ไว้ในตัวแปร
                    System.Console.WriteLine(item);
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

    public class Product : IProduct
    {
        public string SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}