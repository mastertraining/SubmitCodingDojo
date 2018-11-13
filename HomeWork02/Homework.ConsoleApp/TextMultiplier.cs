using System;
using System.Linq;
using System.Text;

namespace Homework.ConsoleApp
{
    public class TextMultiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var sequence = ConvertTextToArrayMultipliedBy11(text);
            var textLine = string.Join(",\n\t",sequence);
            var newText = new StringBuilder();
            newText.Append($"[\n\t{textLine}\n]");
            return newText.ToString();
        }

        public string[] ConvertTextToArrayMultipliedBy11(string text)
        {
            var sequence = text.Split(',').Select(it => (int.Parse(it) * 11).ToString()).ToArray();
            return sequence;
        }

    }
}