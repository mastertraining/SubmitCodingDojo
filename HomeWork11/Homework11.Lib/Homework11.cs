using Homework11.Lib.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework11.Lib
{
    public class Homework11 : IHomework11
    {
        private string ConvertFromDigit(string number, int position)
        {
            if (number == "0") return string.Empty;

            var letter = new StringBuilder();

            var letterKey = position == 1 && number == "1" ? LetterReader.SpecialOneKey : number.ToString();
            letter.Append(LetterReader.MyLetterReader.GetValueOrDefault(letterKey));

            var digitReaderKey = position == 2 && number == "2" ? LetterReader.SpecialTwentyKey : string.Format("*{0}", position.ToString());
            letter.Append(LetterReader.MyDigitReader.GetValueOrDefault(digitReaderKey));

            return letter.ToString();
        }

        public string GetReadWordOfNumber(int number)
        {
            var stringNumber = number.ToString();
            if (stringNumber.Count() == 1) return LetterReader.MyLetterReader.GetValueOrDefault(stringNumber);

            var result = new StringBuilder();
            foreach (var item in stringNumber)
            {
                result.Append(ConvertFromDigit(stringNumber.First().ToString(), stringNumber.Count()));
                stringNumber = stringNumber.Remove(0, 1);
            }

            return result.ToString();
        }
    }
}
