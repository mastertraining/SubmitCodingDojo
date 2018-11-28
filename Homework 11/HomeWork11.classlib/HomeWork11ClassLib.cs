using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace HomeWork11.classlib
{
    public class HomeWork11ClassLib : IHomework11
    {
        public Dictionary<int, string> Digit { get; set; }
        public Dictionary<int, string> Number { get; set; }

        public void setDigit()
        {
            Digit = new Dictionary<int, string>() {
                {1,string.Empty},
                {2,"สิบ"},
                {3,"ร้อย"},
                {4,"พัน"},
                {5,"หมื่น"},
                {6,"แสน"},
                {7,"ล้าน"}
            };

            Number = new Dictionary<int, string>() {
                {0,"ศูนย์"},
                {1,"หนึ่ง"},
                {2,"สอง"},
                {3,"สาม"},
                {4,"สี่"},
                {5,"ห้า"},
                {6,"หก"},
                {7,"เจ็ด"},
                {8,"แปด"},
                {9,"เก้า"},
            };
        }

        public string GetReadWordOfNumber(int number)
        {
            var numberSB = new StringBuilder();
            if (number < 10000000)
            {
                var numberString = number.ToString();
                var listDigit = new List<int>();
                for (int i = 0; i < numberString.Count(); i++)
                {
                    var num = int.Parse(numberString.Substring(i, 1));
                    listDigit.Add(num);
                }

                for (int i = 0; i < listDigit.Count; i++)
                {
                    var wordNumber = Number[listDigit[i]];
                    var wordDigit = Digit[listDigit.Count - i];
                    switch (listDigit[i])
                    {
                        case 0:
                            if (listDigit.Count > 1)
                            {
                                wordNumber = string.Empty;
                                wordDigit = string.Empty;
                            }
                            break;
                        case 1:
                            if (wordDigit == "สิบ")
                            {
                                wordNumber = string.Empty;
                            }
                            else if (listDigit.Count > 1 && i == listDigit.Count - 1)
                            {
                                wordNumber = "เอ็ด";
                            }
                            break;
                        case 2:
                            wordNumber = wordDigit == "สิบ" ? "ยี่" : wordNumber;
                            break;
                        default:
                            break;
                    }
                    numberSB.Append(wordNumber).Append(wordDigit);
                }
            }
            else
            {
                numberSB.Append("The Number is Over!!");
            }
            return numberSB.ToString();
        }
    }
}
