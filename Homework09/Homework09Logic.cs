using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homework09
{
    class Homework09Logic : IHomework09
    {
        private const string FileName = @"product.csv";  //1.เก็บไฟลล์ .csv ไว้ในตัวแปร
        private List<Product> _products; //1.3 ประกาศตัวแปรที่โดนaddค่า ในclass เพื่อที่methodอื่นจะได้เรียกใช้ได้
        private List<Product> AddProductCart { get; set; } //2.2 ประกาศตัวแปรเพื่อเก็บค่า ทำเป็นlist(โกดัง)เพื่อ add ของได้เยอะๆ
        public Homework09Logic() //สร้าง constractor(ทุกครั้งที่เปิดอันนี้จะทำงาน ต้องชื่อเดียวกับคลาส)
        {
            _products = new List<Product>(); // 1.4 ประกาศ obj.เพื่อให้รู้ว่าจะเก็บของไว้ที่ไหน
            LoadCSVFile();
        }

        private void LoadCSVFile() //1.2 อ่านไฟลล์ csv 
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
                    _products.Add(product); //1.5 เก็บค่าที่ add ไว้ในตัวแปร
                    System.Console.WriteLine(item);
                }
            }
        }

        public void AddProductToCart(IProduct product) // 2. รับของเข้ามาที่มีค่าเป็น Iproduct(type)
        {
            var collect = new Product //2.1 สร้าง obj ใหม่เพื่อ addค่าให้กับของในนั้น (convert type)
            {
                //skuตัวหน้าเรียกจากclass ของProduct = .sku ตัวหลังคือ prop ที่อยู่ข้างในIProduct
                SKU = product.SKU, 
                Name = product.Name,
                Price = product.Price
            };
            AddProductCart.Add(collect); //2.3 เก็บค่าที่ add ไว้ในตัวแปรที่ประกาศด้านบน
            
            // var collect = new Product();
            //AddProductCart.Add(product); //ทำไม่ได้มันคนละ type ต้องทำการ convert type ก่อน
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