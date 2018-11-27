using System;
using System.Linq;

namespace homework11
{
    public class GetReadWordOfNumberLogic : IHomework11
    {
        public string GetReadWordOfNumber(int number)
        {
            var strNumber = number.ToString();
            if (strNumber.Length == 2)
            {
                var result = "";
                if (strNumber[0] == '1')
                {
                    result = "สิบ";
                }
                else if (strNumber[0] == '2')
                {
                    result = "ยี่สิบ";
                }
                else
                {
                    var actual = Get1digit(strNumber[0]);
                    result = ($"{actual}สิบ");
                }
                if (strNumber[1]=='0')
                {
                    return result;
                }
                var get1Digit = Get1digit(strNumber[1]);
                return ($"{result}{get1Digit}");
            }                     
            else
            {
                return Get1digit(strNumber[0]);
            }

        }

        public string Get1digit(char number)
        {
            if (number == '0')
            {
                return "ศูนย์";
            }
            else if (number == '1')
            {
                return "หนึ่ง";
            }
            else if (number == '2')
            {
                return "สอง";
            }
            else if (number == '3')
            {
                return "สาม";
            }
            else if (number == '4')
            {
                return "สี่";
            }
            else if (number == '5')
            {
                return "ห้า";
            }
            else if (number == '6')
            {
                return "หก";
            }
            else if (number == '7')
            {
                return "เจ็ด";
            }
            else if (number == '8')
            {
                return "แปด";
            }
            else
            {
                return "เก้า";
            }
        }
    }
}
