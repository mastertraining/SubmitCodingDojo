using System;

namespace hw11
{
    public class logic : IHomework11
    {
        public string GetReadWordOfNumber(int number)
        {
            string number2 = number.ToString();

            if (number2.Length == 7)
            {
                switch (number2[0])
                {
                    case '0': return "";
                    default:
                        if (number % 1000000 == 0)
                        {
                            return ($"{ReadNumber(number2[0])}ล้าน");
                        }
                        else
                        {
                            return ($"{ReadNumber(number2[0])}ล้าน{GetReadWordOfNumber(number % 1000000)}");
                        }
                }
            }

            if (number2.Length == 6)
            {
                switch (number2[0])
                {
                    case '0': return "";
                    default:
                        if (number % 100000 == 0)
                        {
                            return ($"{ReadNumber(number2[0])}แสน");
                        }
                        else
                        {
                            return ($"{ReadNumber(number2[0])}แสน{GetReadWordOfNumber(number % 100000)}");
                        }
                }
            }

            if (number2.Length == 5)
            {
                switch (number2[0])
                {
                    case '0': return "";
                    default:
                        if (number % 10000 == 0)
                        {
                            return ($"{ReadNumber(number2[0])}หมื่น");
                        }
                        else
                        {
                            return ($"{ReadNumber(number2[0])}หมื่น{GetReadWordOfNumber(number % 10000)}");
                        }
                }
            }

            if (number2.Length == 4)
            {
                switch (number2[0])
                {
                    case '0': return "";
                    default:
                        if (number % 1000 == 0)
                        {
                            return ($"{ReadNumber(number2[0])}พัน");
                        }
                        else
                        {
                            return ($"{ReadNumber(number2[0])}พัน{GetReadWordOfNumber(number % 1000)}");
                        }
                }
            }

            if (number2.Length == 3)
            {

                switch (number2[0])
                {
                    case '0': return "";
                    default:
                        if (number % 100 == 0)
                        {
                            return ($"{ReadNumber(number2[0])}ร้อย");
                        }
                        else
                        {
                            return ($"{ReadNumber(number2[0])}ร้อย{GetReadWordOfNumber(number % 100)}");
                        }
                }
            }

            if (number2.Length == 2)
            {
                switch (number2[0])
                {
                    case '1':
                        string ten = "สิบ";
                        if (number2[1] == '0')
                        {

                            return ten;
                        }
                        if (number2[1] == '1')
                        {

                            return ($"{ten}เอ็ด");
                        }
                        else
                        {
                            string result = ReadNumber(number2[1]);
                            return ($"{ten}{result}");
                        }
                    case '2':
                        string twenty = "ยี่สิบ";
                        if (number2[1] == '0')
                        {

                            return twenty;
                        }
                        if (number2[1] == '1')
                        {

                            return ($"{twenty}เอ็ด");
                        }
                        else
                        {
                            string result = ReadNumber(number2[1]);
                            return ($"{twenty}{result}");
                        }

                    default:

                        string x = ($"{ReadNumber(number2[0])}สิบ");
                        if (number2[1] == '0')
                        {

                            return x;
                        }
                        if (number2[1] == '1')
                        {

                            return ($"{x}เอ็ด");
                        }
                        else
                        {
                            string result = ReadNumber(number2[1]);
                            return ($"{x}{result}");
                        }

                }


            }
            else
            {
                return ReadNumber(number2[0]);
            }
        }

        public string ReadNumber(char number2)
        {
            switch (number2)
            {
                case '9': return "เก้า";
                case '8': return "แปด";
                case '7': return "เจ็ด";
                case '6': return "หก";
                case '5': return "ห้า";
                case '4': return "สี่";
                case '3': return "สาม";
                case '2': return "สอง";
                case '1': return "หนึ่ง";
                case '0': return "ศูนย์";
                default: return "";
            }

        }
    }
}