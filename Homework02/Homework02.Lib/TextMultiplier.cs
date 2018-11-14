using System;
using System.Linq;
using System.Text;

namespace Homework02.Lib
{
    public class TextMultiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var newString = new StringBuilder();
            var strSplit = text.Split(',').Select(x => (Int32.Parse(x) * 11).ToString()).ToArray();
            var joinStr = string.Join(",\n\t", strSplit);
            return newString.Append($"[\n\t{joinStr}\n]").ToString();
        }
    }
}
