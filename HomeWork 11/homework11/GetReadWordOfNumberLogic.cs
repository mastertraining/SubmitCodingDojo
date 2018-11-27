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
                if (strNumber == "0")
                {
                    return "ศูนย์";
                }
                else if (strNumber == "1")
                {
                    return "หนึ่ง";
                }
                else if (strNumber == "2")
                {
                    return "สอง";
                }
                else if (strNumber == "3")
                {
                    return "สาม";
                }
                else if (strNumber == "4")
                {
                    return "สี่";
                }
                else if (strNumber == "5")
                {
                    return "ห้า";
                }
                else if (strNumber == "6")
                {
                    return "หก";
                }
                else if (strNumber == "7")
                {
                    return "เจ็ด";
                }
                else if (strNumber == "8")
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
}
