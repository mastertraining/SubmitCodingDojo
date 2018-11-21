using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02
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
