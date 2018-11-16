using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace demoupper
{
    class Program
    {
        static void Main(string[] args)
        {
            //รับจำนวนที่จะนำมาเป็นตัวพิมพ์ใหญ่ แล้วสร้างตัวแปร string[] เพื่อเก็บจำนวนนั้น
            // **เก็บเป็น string[],List เพราะค่าที่รับเข้ามามีได้หลายค่า **
            Console.WriteLine("How many word do you want to convert to Capitalize??");
            var count = int.Parse(Console.ReadLine());
            var text = new string[count];

            //วนลูปตามจำนวนที่ใส่เข้ามา โดยแต่ครั้งที่วนลูปให้ใส่ตัวอักษรที่จะconvert
            Console.WriteLine("Enter your word");
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = Console.ReadLine();
            }

            //ส่งค่าที่รับเข้าจากบรรทัดบนทั้งก้อน (string[]) ไปให้ method ที่สร้างไว้
            //ใช้ method (เก็บค่าแล้วเลือกตัวนั้นมาทำเป็น 'พิมพ์ใหญ่') 
            var sut = new Homework03();
            var result = sut.CapitalizedText(text);

            //เอาค่าที่รับกลับมา มาแสดงทีละตัว
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            //ประกาศ[] และ ประกาศList
            // string[] input = new string[]{};
            // var a = new string[]{};    
            // var input = new List<string>();

            // //รับจำนวนที่จะนำมาเป็นตัวพิมพ์ใหญ่ แล้วสร้างตัวแปร[]เพื่อเก็บค่านั้นตามจำนวนที่ป้อนเข้ามา
            // var count = int.Parse(Console.ReadLine());
            // var text = new string[count];

            // // //วนลูปเพื่อป้อนค่าแต่ละค่า
            // for (int i = 0; i < text.Length; i++)
            // {
            //     text[i] = Console.ReadLine();
            // }


            // var input = (Console.ReadLine());
            // var valid = string.IsNullOrEmpty(input);
            // while (valid == false)
            // {
            // //เก็บค่าแล้วเลือกตัวนั้นมาทำเป็น 'พิมพ์ใหญ่'
            // var result = input.Select(it => it.ToUpper());
            // //เอาค่านั้นมาแสดง
            // foreach (var item in result)
            // {
            //     System.Console.WriteLine(item);
            // }
            // }




            // //ใส่ค่าทีละตัว
            // var input = Console.ReadLine();
            // //เก็บค่าแล้วเลือกตัวนั้นมาทำเป็น 'พิมพ์ใหญ่'
            // var result = input.ToUpper();
            // //เอาค่านั้นมาแสดง
            // Console.WriteLine(result);
        }
    }
}

