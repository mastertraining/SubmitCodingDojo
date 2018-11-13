using System;
using System.Linq;
using System.Text;

namespace Homework02.Lib
{
    public class TextMultiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var splittedText = text.Split(',');
            var arrayStringNumberWithMul11 = splittedText.Select(it => (int.Parse(it) * 11).ToString()).ToArray();
            var joinedString = string.Join(",\n\t", arrayStringNumberWithMul11);
            var result = new StringBuilder();
            result.Append("[\n\t").Append(joinedString).Append("\n]");
            return result.ToString();
        }
    }
}
