using System;

namespace homework11class
{
    public class Logic : IHomework11
    {
        public string GetReadWordOfNumber(int number)
        {
            var text = number.ToString();
            if (text.Length == 2)
            {
                if (text[0] == '1')
                {
                   var ten = "สิบ";
                   var twodigit = Getonedigit(text[1]);
                    return ($"{ten}{twodigit}");
                }
                else if (text[0] == '2')
                {
                    return "ยี่สิบ";
                }
                else if (text[0] >= '3' && text[0] > '0')
                {
                    var onedigit = Getonedigit(text[0]);
                    return ($"{onedigit}สิบ");

                }
            }
            else
            {
                return Getonedigit(text[0]);
            }

            return "";
        }

        public string Getonedigit(char onedigit)
        {
            if (onedigit == '9')
            {
                return "เก้า";
            }
            else if (onedigit == '8')
            {
                return "แปด";
            }
            else if (onedigit == '7')
            {
                return "เจ็ด";
            }
            else if (onedigit == '6')
            {
                return "หก";
            }
            else if (onedigit == '5')
            {
                return "ห้า";
            }
            else if (onedigit == '4')
            {
                return "สี่";
            }
            else if (onedigit == '3')
            {
                return "สาม";
            }
            else if (onedigit == '2')
            {
                return "สอง";
            }
            else if (onedigit == '1')
            {
                return "หนึ่ง";
            }
            else
            {
                return "ศูนย์";
            }

        }

    }
}
