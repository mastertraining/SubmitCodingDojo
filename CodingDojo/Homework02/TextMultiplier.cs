using System;
using System.Collections.Generic;

namespace Homework02
{
    public class TextMultiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var textArray = text.Split(',');
            var formatNumberList = new List<string>();
            foreach (var StrNumber in textArray)
            {
                var formatNumber = double.Parse(StrNumber) * 11;
                formatNumberList.Add($"{Environment.NewLine}\t{formatNumber}");
            }
            var formattedStr = string.Join(",", formatNumberList);
            return $"[{formattedStr}{Environment.NewLine}]";
        }
    }
}
