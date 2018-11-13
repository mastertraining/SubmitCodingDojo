using System;

namespace Homework.Lib
{
    public class MultipliedBy11 : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var split = text.Split(',');
            for (int i = 0; i < split.Length; i++)
            {
                var convert = int.Parse(split[i]);
                split[i] = (convert * 11).ToString();
            }

            var result = string.Format("[/n/t{0},/n/t{1},/n/t{2},/n/t{3},/n/t{4},/n/t{5}/n]",
            split[0],split[1],split[2],split[3],split[4],split[5]);
            return result;
        }

    }
}
