using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace HomeWork11.classlib
{
    public class HomeWork11ClassLib : IHomework11
    {
        public Dictionary<int, string> digitNumber { get; set; }

        public void setDigit()
        {
            digitNumber = new Dictionary<int, string>() {
                {1000000,"ล้าน"},
                {100000,"แสน"},
                {10000,"หมื่น"},
                {1000,"พัน"},
                {100,"ร้อย"},
                {20,"ยี่สิบ"},
                {10,"สิบ"},
                {9,"เก้า"},
                {8,"แปด"},
                {7,"เจ็ด"},
                {6,"หก"},
                {5,"ห้า"},
                {4,"สี่"},
                {3,"สาม"},
                {2,"สอง"},
                {1,"หนึ่ง"},
                {0,"ศูนย์"},
            };
        }
        public string GetReadWordOfNumber(int number)
        {
            var digit = 0;
            var numberSB = new StringBuilder();
            var result = number;
            if (result >= 1000000)
            {
                digit = result / 1000000;
                result = result - (digit * 1000000);
                numberSB.Append(digitNumber[digit]).Append(digitNumber[1000000]);

            }
            if (result >= 100000)
            {
                digit = result / 100000;
                result = result - (digit * 100000);
                numberSB.Append(digitNumber[digit]).Append(digitNumber[100000]);
            }
            if (result >= 10000)
            {
                digit = result / 10000;
                result = result - (digit * 10000);
                numberSB.Append(digitNumber[digit]).Append(digitNumber[10000]);
            }
            if (result >= 1000)
            {
                digit = result / 1000;
                result = result - (digit * 1000);
                numberSB.Append(digitNumber[digit]).Append(digitNumber[1000]);
            }
            if (result >= 100)
            {
                digit = result / 100;
                result = result - (digit * 100);
                numberSB.Append(digitNumber[digit]).Append(digitNumber[100]);
            }
            if (result >= 20 && result < 30)
            {
                digit = result / 20;
                result = result - (digit * 20);
                numberSB.Append(digitNumber[20]);
            }
            if (result >= 10 && result < 20)
            {
                digit = result / 10;
                result = result - (digit * 10);
                numberSB.Append(digitNumber[10]);
            }
            if (result > 10)
            {
                digit = result / 10;
                result = result - (digit * 10);
                numberSB.Append(digitNumber[digit]).Append(digitNumber[10]);
            }
            if (result == 1 && number >= 10)
            {
                digit = result / 1;
                numberSB.Append("เอ็ด");
            }
            if (result == 1 && number < 10)
            {
                numberSB.Append(digitNumber[1]);
            }
            if (result > 1)
            {
                digit = result / 1;
                numberSB.Append(digitNumber[digit]);
            }
            if (number == 0)
            {
                numberSB.Append(digitNumber[0]);
            }
            return numberSB.ToString();
        }
    }
}
