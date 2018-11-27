using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_11
{
    public class Homework11 : IHomework11
    {
        public IDictionary<CoreBase, string> baseThaiNumber;
        public IDictionary<int, string> thaiNumber;
        public enum CoreBase
        {
            Hundred_Thousand = 0,
            Ten_Thousand = 1,
            Thousand = 2,
            Hundred = 3,
            Ten = 4,
            Million
        }

        public Homework11()
        {
            baseThaiNumber = new Dictionary<CoreBase, string>
            {
                { CoreBase.Ten, "สิบ"},
                { CoreBase.Hundred, "ร้อย"},
                { CoreBase.Thousand, "พัน"},
                { CoreBase.Ten_Thousand, "หมื่น"},
                { CoreBase.Hundred_Thousand, "แสน"},
                { CoreBase.Million, "ล้าน"},
            };
            thaiNumber = new Dictionary<int, string>
            {
                { 0, "ศูนย์"},
                { 1, "หนึ่ง"},
                { 2, "สอง"},
                { 3, "สาม"},
                { 4, "สี่"},
                { 5, "ห้า"},
                { 6, "หก"},
                { 7, "เจ็ด"},
                { 8, "แปด"},
                { 9, "เก้า"},
                { 11, "เอ็ด"},
                { 20, "ยี่"},
            };
        }

        private IList<string> GetSixDigitListOfNumber(int number)
        {
            var saveFormat = "000000";
            var sixDigitList = new List<string>();
            var sixDigitStr = string.Empty;
            foreach (var oneDigit in number.ToString().Reverse())
            {
                sixDigitStr = oneDigit + sixDigitStr;
                if (sixDigitStr.Length >= 6)
                {
                    sixDigitList.Add(int.Parse(sixDigitStr).ToString(saveFormat));
                    sixDigitStr = string.Empty;
                }
            }
            if (sixDigitStr.Length > 0)
                sixDigitList.Add(int.Parse(sixDigitStr).ToString(saveFormat));
            sixDigitList.Reverse();
            return sixDigitList;
        }

        public string GetReadWordOfNumber(int number)
        {
            var sixDigitList = GetSixDigitListOfNumber(number);
            var thaiNumberWordBuilder = new StringBuilder();
            foreach (var sixDigitItem in sixDigitList)
            {
                var millionWordCount = sixDigitList.Count - sixDigitList.IndexOf(sixDigitItem) - 1;
                if (int.Parse(sixDigitItem) < 10 && sixDigitList.IndexOf(sixDigitItem) == 0)
                {
                    thaiNumberWordBuilder.Append(BaseOneNumberToString(int.Parse(sixDigitItem), true));
                }
                else
                {
                    var numberArray = sixDigitItem.Select(it => int.Parse(it.ToString())).ToList();
                    for (int i = 0; i < numberArray.Count - 1; i++)
                    {
                        if (numberArray[i] == 0 && i < 4) continue;
                        thaiNumberWordBuilder.Append(GetThaiNumberWordForeachBase(numberArray[i], numberArray[5], (CoreBase)i));
                    }
                }
                baseThaiNumber.TryGetValue(CoreBase.Million, out var millionWord);
                var millonThaiWords = new string('A', millionWordCount).Replace("A", millionWord);
                thaiNumberWordBuilder.Append(millonThaiWords);
            }
            return thaiNumberWordBuilder.ToString();
        }

        private string GetThaiNumberWordForeachBase(int mainNumber, int lastNumber, CoreBase coreBase)
        {
            thaiNumber.TryGetValue(mainNumber, out var thaiNumberWord);
            var baseWord = string.Empty;
            switch (coreBase)
            {
                case CoreBase.Ten:
                    return BaseTenToString(mainNumber, lastNumber);
                case CoreBase.Hundred:
                    baseThaiNumber.TryGetValue(CoreBase.Hundred, out baseWord);
                    break;
                case CoreBase.Thousand:
                    baseThaiNumber.TryGetValue(CoreBase.Thousand, out baseWord);
                    break;
                case CoreBase.Ten_Thousand:
                    baseThaiNumber.TryGetValue(CoreBase.Ten_Thousand, out baseWord);
                    break;
                case CoreBase.Hundred_Thousand:
                    baseThaiNumber.TryGetValue(CoreBase.Hundred_Thousand, out baseWord);
                    break;
                default:
                    break;
            }
            return $"{thaiNumberWord}{baseWord}";
        }

        private string BaseTenToString(int secondDigit, int firstDigit)
        {
            if (secondDigit == 0) return BaseOneNumberToString(firstDigit, false);
            var secondDisgitWord = string.Empty;
            if (secondDigit == 2) thaiNumber.TryGetValue(20, out secondDisgitWord);
            else if (secondDigit != 1) thaiNumber.TryGetValue(secondDigit, out secondDisgitWord);
            baseThaiNumber.TryGetValue(CoreBase.Ten, out var baseWord);
            return $"{secondDisgitWord}{baseWord}{BaseOneNumberToString(firstDigit, false)}";
        }

        private string BaseOneNumberToString(int number, bool isOneDigit)
        {
            if (!isOneDigit && number == 1)
            {
                thaiNumber.TryGetValue(11, out var result);
                return result;
            }
            else
            {
                if (!isOneDigit && number == 0) return string.Empty;
                thaiNumber.TryGetValue(number, out var result);
                return result;
            }
        }
    }
}
