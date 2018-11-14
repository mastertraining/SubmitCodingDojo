using HomeWirk.lib.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork01.lib
{
    public class TextMultiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var split = text.Split(",");
            var data = split.Select(it => (int.Parse(it) * 11).ToString());
            var join = string.Join(",\n\t", data);
            var result = new StringBuilder();
            result.Append("[").AppendLine().Append("\t").Append(join).AppendLine().Append("]");
            string xxx = "x" + "y";
            return result.ToString();
        }
    }
}
