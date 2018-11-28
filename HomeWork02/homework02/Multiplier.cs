using System;
using System.Linq;
using System.Text;
using static homework02.TextMultiplier;

namespace homework02
{
    public class Multiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var split = text.Split(',');
            var textMultiplier11 = split.Select(it => int.Parse(it)*11).ToArray();
            var intStrings = string.Join(",\n\t", textMultiplier11);
            StringBuilder sb = new StringBuilder();
            sb.Append("[\n\t")
            .Append(intStrings)
            .Append("\n]");
            return sb.ToString();          
        }
    }
}
