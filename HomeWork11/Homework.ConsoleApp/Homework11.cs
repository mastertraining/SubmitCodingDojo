using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework.ConsoleApp
{
    public class Homework11 : IHomework11
    {
        public Dictionary<int, string> Number { get; set; }
        public Dictionary<int, string> PlaceValue { get; set; }

        public Homework11()
        {
            Number = new Dictionary<int, string>{
                {0,"ศูนย์"},
                {1,"หนึ่ง"},
                {2,"สอง"},
                {3,"สาม"},
                {4,"สี่"},
                {5,"ห้า"},
                {6,"หก"},
                {7,"เจ็ด"},
                {8,"แปด"},
                {9,"เก้า"}
            };

            PlaceValue = new Dictionary<int, string>{
                {1,string.Empty},
                {2,"สิบ"},
                {3,"ร้อย"},
                {4,"พัน"},
                {5,"หมื่น"},
                {6,"แสน"},
                {7,"ล้าน"}
            };
        }

        public string GetReadWordOfNumber(int number)
        {
            var stringOfNumber = number.ToString();
            var digit = stringOfNumber.Count();
            var listOfNumber = new int[digit];
            for (int i = 0; i < digit; i++)
            {
                listOfNumber[i] = int.Parse(stringOfNumber.Substring(i, 1));
            }
            var wordOfNumber = new StringBuilder();
            for (int i = 0; i < digit; i++)
            {
                var word = Number[listOfNumber[i]];
                var placeValue = PlaceValue[digit - i];
                switch (listOfNumber[i])
                {
                    case 0:
                        if (digit > 1) word = placeValue = string.Empty;
                        break;
                    case 1:
                        if (placeValue == "สิบ") word = string.Empty;
                        else if (digit > 1 && i == digit - 1) word = "เอ็ด";
                        break;
                    case 2:
                        if (placeValue == "สิบ") word = "ยี่";
                        break;
                    default:
                        break;
                }
                wordOfNumber.Append(word).Append(placeValue);
            }
            return wordOfNumber.ToString();
        }
    }
}