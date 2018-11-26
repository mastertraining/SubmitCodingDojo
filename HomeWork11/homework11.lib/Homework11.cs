using System;
using System.Text;

namespace homework11.lib
{
    public class Homework11 : IHomework11
    {
        public string GetReadWordOfNumber(int number)
        {
            var isZeroNumberOnly = number == 0;
            if (isZeroNumberOnly) return "ศูนย์";

            var actucalNumber = number;
            var result = new StringBuilder();

            const int MinimumValue = 1;
            var numberLength = number.ToString().Length;
            var powNumberForStartDigit = numberLength - 1;
            var startDigit = (int)Math.Pow(10, powNumberForStartDigit);
            for (int digit = startDigit; digit > 0; digit /= 10)
            {
                var value = (int)actucalNumber / digit;
                var hasAnyValue = value >= MinimumValue;
                if (!hasAnyValue) continue;
                actucalNumber -= value * digit;

                const int DigitMillion = 7;
                var currentDigit = digit.ToString().Length;
                var isDigitMoreThanMillion = digit.ToString().Length > DigitMillion;
                if (isDigitMoreThanMillion) currentDigit = (digit / (int)Math.Pow(10, DigitMillion - 1)).ToString().Length;

                if (currentDigit >= 3)
                {
                    var word = GetWordOfNumberMoreThanThreeDigit(value);
                    var displayDigitNumber = currentDigit > 6 ?
                                             "ล้าน" : currentDigit > 5 ?
                                             "แสน" : currentDigit > 4 ?
                                             "หมื่น" : currentDigit > 3 ?
                                             "พัน" : "ร้อย";
                    result.Append($"{word}{displayDigitNumber}");
                }
                else if (currentDigit >= 2)
                {
                    var word = GetWordOfNumberIsTwoDigit(value);
                    result.Append($"{word}สิบ");
                }
                else
                {
                    var word = GetWordOfNumberIsOneDigit(value);
                    result.Append(word);
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
