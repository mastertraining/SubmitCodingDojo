using System;
using System.Text;
namespace homework01.lib
{
    public class TextSorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var split = text.Split(',');
            Array.Sort(split);

            var builder = new StringBuilder();
            for (int i = 0; i < split.Length; i++)
            {
                if (i == 0)
                {
                    builder.Append(split[i]);
                }
                else
                {
                    builder.Append(",").Append(split[i]);
                }
            }

            return builder.ToString();
        }
    }
}
