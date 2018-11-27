using System;
using System.Collections.Generic;
using System.Text;

namespace hw11ClassLib
{
    public class Homework11 : IHomework11
    {
        public Dictionary<int, string> wordNumber { get; set; }
        public Homework11()
        {
            wordNumber = new Dictionary<int, string>() {
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
            var build = new StringBuilder();
            var result = number;

            if (result > 9999999)
            {
                build.Append("เกินขอบเขต");
            }
            else
            {
                if (result >= 1000000)
                {
                    digit = result / 1000000;
                    result = result % 1000000;
                    build.Append(wordNumber[digit]).Append(wordNumber[1000000]);
                }
                if (result >= 100000)
                {
                    digit = result / 100000;
                    result = result % 100000;
                    build.Append(wordNumber[digit]).Append(wordNumber[100000]);
                }
                if (result >= 10000)
                {
                    digit = result / 10000;
                    result = result % 10000;
                    build.Append(wordNumber[digit]).Append(wordNumber[10000]);
                }
                if (result >= 1000)
                {
                    digit = result / 1000;
                    result = result % 1000;
                    build.Append(wordNumber[digit]).Append(wordNumber[1000]);
                }
                if (result >= 100)
                {
                    digit = result / 100;
                    result = result % 100;
                    build.Append(wordNumber[digit]).Append(wordNumber[100]);
                }
                if (result >= 20 && result < 30)
                {
                    digit = result / 20;
                    result = result % 20;
                    build.Append(wordNumber[20]);
                }
                if (result >= 10 && result < 20)
                {
                    digit = result / 10;
                    result = result % 10;
                    build.Append(wordNumber[10]);
                }
                if (result > 10)
                {
                    digit = result / 10;
                    result = result % 10;
                    build.Append(wordNumber[digit]).Append(wordNumber[10]);
                }
                if (result == 1 && number >= 10)
                {
                    digit = result / 1;
                    build.Append("เอ็ด");
                }
                if (result == 1 && number < 10)
                {
                    build.Append(wordNumber[1]);
                }
                if (result > 1)
                {
                    digit = result / 1;
                    build.Append(wordNumber[digit]);
                }
                if (number == 0)
                {
                    build.Append(wordNumber[0]);
                }
            }

            return build.ToString();
        }
    }
}
