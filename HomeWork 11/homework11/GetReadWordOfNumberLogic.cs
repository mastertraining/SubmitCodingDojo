using System;
using System.Linq;

namespace homework11
{
    public class GetReadWordOfNumberLogic : IHomework11
    {
        public string GetReadWordOfNumber(int number)
        {
            var strNumber = number.ToString();
            var result = "";
            if (strNumber.Length == 7)
            {
                var million = Get1digit(strNumber[0]);
                if (number % 1000000 == 0)
                {
                    return ($"{million}ล้าน");
                }
                else
                {
                    return ($"{million}ล้าน{GetReadWordOfNumber(number % 1000000)}");
                }
            }

            else if (strNumber.Length == 6)
            {
                var hundredThousand = Get1digit(strNumber[0]);
                if (number % 100000 == 0)
                {
                    return ($"{hundredThousand}แสน");
                }
                else
                {
                    return ($"{hundredThousand}แสน{GetReadWordOfNumber(number % 100000)}");
                }
            }

            else if (strNumber.Length == 5)
            {
                var tenThousand = Get1digit(strNumber[0]);
                if (number % 10000 == 0)
                {
                    return ($"{tenThousand}หมื่น");
                }
                else
                {
                    return ($"{tenThousand}หมื่น{GetReadWordOfNumber(number % 10000)}");
                }
            }

            else if (strNumber.Length == 4)
            {
                var thousand = Get1digit(strNumber[0]);
                if (number % 1000 == 0)
                {
                    return ($"{thousand}พัน");
                }
                else
                {
                    return ($"{thousand}พัน{GetReadWordOfNumber(number % 1000)}");
                }
            }
            else if (strNumber.Length == 3)
            {
                var hundred = Get1digit(strNumber[0]);
                if (number % 100 == 0)
                {
                    return ($"{hundred}ร้อย");
                }
                else
                {
                    return ($"{hundred}ร้อย{GetReadWordOfNumber(number % 100)}");
                }
            }

            else if (strNumber.Length == 2)
            {
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

                if (strNumber[1] == '0')
                {
                    return result;
                }
                else if (strNumber[1] == '1')
                {
                    return ($"{result}เอ็ด");
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
