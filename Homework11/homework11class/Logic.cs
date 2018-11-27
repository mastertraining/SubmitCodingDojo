using System;

namespace homework11class
{
    public class Logic : IHomework11
    {
        public string GetReadWordOfNumber(int number)
        {   //12
            var text = number.ToString();
            if (text.Length == 2)
            {
               if (text == "90")
                {
                    return "เก้าสิบ";
                }
                if (text == "80")
                {
                    return "แปดสิบ";
                }
                if (text == "70")
                {
                    return "เจ็ดสิบ";
                }
                if (text == "60")
                {
                    return "หกสิบ";
                }
                if (text == "50")
                {
                    return "ห้าสิบ";
                }
                if (text == "40")
                {
                    return "สี่สิบ";
                }
                if (text == "30")
                {
                    return "สามสิบ";
                }
                if (text == "20")
                {
                    return "ยี่สิบ";
                }
                if (text == "10")
                {
                    return "สิบ";
                } 
            }
            else
            {
                if (text == "9")
                {
                    return "เก้า";
                }
                if (text == "8")
                {
                    return "แปด";
                }
                if (text == "7")
                {
                    return "เจ็ด";
                }
                if (text == "6")
                {
                    return "หก";
                }
                if (text == "5")
                {
                    return "ห้า";
                }
                if (text == "4")
                {
                    return "สี่";
                }
                if (text == "3")
                {
                    return "สาม";
                }
                if (text == "2")
                {
                    return "สอง";
                }
                if (text == "1")
                {
                    return "หนึ่ง";
                }
                if (text == "0")
                {
                    return "ศูนย์";
                }
            }

            return "";

        }
    }
}
