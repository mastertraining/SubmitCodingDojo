using System;

namespace homework11class
{
    public class Logic : IHomework11
    {
        public string GetReadWordOfNumber(int number)
        {
            var text = number.ToString();
            if (text.Length == 7)
            {
                if (number % 1000000 == 0)
                {
                    var millionequal0 = Getonedigit(text[0]);
                    return ($"{millionequal0}ล้าน");
                }
                var million = Getonedigit(text[0]);
                return ($"{million}ล้าน{GetReadWordOfNumber(number % 1000000)}");
            }
            else if (text.Length == 6)
            {
                if (number % 100000 == 0)
                {
                    var hundredthousandqual0 = Getonedigit(text[0]);
                    return ($"{hundredthousandqual0}แสน");
                }
                var hundredthousand = Getonedigit(text[0]);
                return ($"{hundredthousand}แสน{GetReadWordOfNumber(number % 100000)}");
            }
            else if (text.Length == 5)
            {
                if (number % 10000 == 0)
                {
                    var tenthousandqual0 = Getonedigit(text[0]);
                    return ($"{tenthousandqual0}หมื่น");
                }
                var tenthousand = Getonedigit(text[0]);
                return ($"{tenthousand}หมื่น{GetReadWordOfNumber(number % 10000)}");
            }
            else if (text.Length == 4)
            {
                if (number % 1000 == 0)
                {
                    var thousandqual0 = Getonedigit(text[0]);
                    return ($"{thousandqual0}พัน");
                }
                var thousand = Getonedigit(text[0]);
                return ($"{thousand}พัน{GetReadWordOfNumber(number % 1000)}");
            }
            else if (text.Length == 3)
            {
                if (number % 100 == 0)
                {
                    var hundredequal0 = Getonedigit(text[0]);
                    return ($"{hundredequal0}ร้อย");
                }
                var hundred = Getonedigit(text[0]);
                return ($"{hundred}ร้อย{GetReadWordOfNumber(number % 100)}");
            }
            else if (text.Length == 2)
            {
                var collect = "";
                if (text[0] == '1')
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
                if (text[1] == '0')
                {
                    return collect;
                }
                if (text[1] == '1')
                {
                    return ($"{collect}เอ็ด");
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

