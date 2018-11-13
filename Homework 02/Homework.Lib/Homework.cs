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

            var join = string.Join(",\n\t",split);
            var result = string.Format("[\n\t{0}\n]",join);
            return result;
        }

    }
}
