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
                if (strNumber == "10")
                {
                    return "สิบ";
                }
                else if (strNumber == "20")
                {
                    return "ยี่สิบ";
                }
                else if (strNumber == "30")
                {
                    return "สามสิบ";
                }
                else if (strNumber == "40")
                {
                    return "สี่สิบ";
                }
                else if (strNumber == "50")
                {
                    return "ห้าสิบ";
                }
                else if (strNumber == "60")
                {
                    return "หกสิบ";
                }
                else if (strNumber == "70")
                {
                    return "เจ็ดสิบ";
                }
                else if (strNumber == "80")
                {
                    return "แปดสิบ";
                }
                else
                {
                    return "เก้าสิบ";
                }
            }
            else
            {
                var get1digit = Get1digit(strNumber[0]);
                return get1digit;
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
