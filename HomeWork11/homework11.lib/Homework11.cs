using System;
using System.Text;

namespace homework11.lib
{
    public class Homework11 : IHomework11
    {
        public string GetReadWordOfNumber(int number)
        {
            if (number == 0) return "ศูนย์";

            var actucalNumber = number;
            var length = number.ToString().Length;
            var result = new StringBuilder();
            for (int digit = (int)(Math.Pow(10, (length - 1))); digit > 0; digit /= 10)
            {
                var value = (int)(actucalNumber / digit);
                if (value < 1) continue;

                actucalNumber -= value * digit;
                var word = string.Empty;

                var x = digit;
                var checkDigit = digit.ToString().Length > 7;
                if (checkDigit) x = digit / 1000000;

                switch (x)
                {
                    case 1000000:
                        word = GetWordOfNumberMoreThanThreeDigit(value);
                        result.Append($"{word}ล้าน");
                        break;
                    case 100000:
                        word = GetWordOfNumberMoreThanThreeDigit(value);
                        result.Append($"{word}แสน");
                        break;
                    case 10000:
                        word = GetWordOfNumberMoreThanThreeDigit(value);
                        result.Append($"{word}หมื่น");
                        break;
                    case 1000:
                        word = GetWordOfNumberMoreThanThreeDigit(value);
                        result.Append($"{word}พัน");
                        break;
                    case 100:
                        word = GetWordOfNumberMoreThanThreeDigit(value);
                        result.Append($"{word}ร้อย");
                        break;
                    case 10:
                        word = GetWordOfNumberIsTwoDigit(value);
                        result.Append($"{word}สิบ");
                        break;
                    case 1:
                        word = GetWordOfNumberIsOneDigit(value);
                        result.Append(word);
                        break;
                    default: break;
                }
            }
            return result.ToString();
        }

        private string GetWordOfNumberMoreThanThreeDigit(int number)
        {
            switch (number)
            {
                case 1: return "หนึ่ง";
                case 2: return "สอง";
                case 3: return "สาม";
                case 4: return "สี่";
                case 5: return "ห้า";
                case 6: return "หก";
                case 7: return "เจ็ด";
                case 8: return "แปด";
                case 9: return "เก้า";
                default: return string.Empty;
            }
        }

        private string GetWordOfNumberIsTwoDigit(int number)
        {
            switch (number)
            {
                case 1: return string.Empty;
                case 2: return "ยี่";
                case 3: return "สาม";
                case 4: return "สี่";
                case 5: return "ห้า";
                case 6: return "หก";
                case 7: return "เจ็ด";
                case 8: return "แปด";
                case 9: return "เก้า";
                default: return string.Empty;
            }
        }

        private string GetWordOfNumberIsOneDigit(int number)
        {
            switch (number)
            {
                case 1: return "เอ็ด";
                case 2: return "สอง";
                case 3: return "สาม";
                case 4: return "สี่";
                case 5: return "ห้า";
                case 6: return "หก";
                case 7: return "เจ็ด";
                case 8: return "แปด";
                case 9: return "เก้า";
                default: return string.Empty;
            }
        }
    }
}
