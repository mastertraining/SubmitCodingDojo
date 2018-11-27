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
                var collect = "";
                if (text[0] == '1' )
                {
                    collect = "สิบ";
                }

                else if (text[0] == '2')
                {
                    collect = "ยี่สิบ";
                }
                else
                {
                    var morethan30 = Getonedigit(text[0]);
                    collect = ($"{morethan30}สิบ");
                }
                var result = Getonedigit(text[1]);
                return ($"{collect}{result}");
            }
            else
            {
                return Getonedigit(text[0]);
            }
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
