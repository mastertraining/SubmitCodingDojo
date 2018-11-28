using System;
using System.Linq;
using System.Text;

namespace homework02.lib
{
    public class TextMultiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var isValid = !string.IsNullOrWhiteSpace(text);
            if (!isValid) return string.Empty;

            var textSplited = text.Split(',').ToList();
            var textTrimed = textSplited.Select(it => it.Trim());
            var sb = new StringBuilder();
            sb.Append("[\n");
            foreach (var item in textTrimed)
            {
                if (int.TryParse(item, out int value))
                {
                    const int multiple = 11;
                    sb.Append("\t").Append(value * multiple);
                    if (item != textTrimed.LastOrDefault()) sb.Append(",\n");
                }
            }
            sb.Append("\n]");
            var result = sb.ToString();
            return result;
        }
    }
}
