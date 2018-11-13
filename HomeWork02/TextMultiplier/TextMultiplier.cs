using System;
using System.Linq;
using System.Text;

namespace TextMultiplier
{
    public class TextMultiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var multipliedSet = GetMultiplierText(text);
            var splitText = multipliedSet.Split(',');
            var builder = new StringBuilder();
            builder.Append("[");
            for (int i = 0; i < splitText.Length; i++)
            {
                builder.Append("\n").Append("\t").Append(splitText[i]);
                if(splitText[i] != splitText.LastOrDefault())
                {
                    builder.Append(",");
                }
            }
            builder.Append("\n").Append("]");
            return builder.ToString();
        }

        public string GetMultiplierText(string text)
        {
            var multipleNumber = 11;
            var splitText = text.Split(',');
            var resultSet = new string[splitText.Length];
            for (int i = 0; i < splitText.Length; i++)
            {
                resultSet[i] = (int.Parse(splitText[i])*multipleNumber).ToString();
            }
            return String.Join(",", resultSet);
        }
    }
}
