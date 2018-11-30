using System;
using System.Text;
using System.Linq;


namespace homework02.lib
{
    public class TextMultiplier : ITextMultiplier
    {
        public string GetFormattedString(string text)
        {
            var split = text.Split(',');
            var multiplie = split.Select(it => (int.Parse(it) * 11).ToString());
            var toArray = multiplie.ToArray();
            // Array.Sort(toArray);
            var builder = new StringBuilder();

            for (int i = 0; i < toArray.Length; i++)
            {
                if (i == 0)
                {
                    builder.Append("[").Append("\n").Append("\t").Append(toArray[i]).Append(",");
                }
                else if (i == toArray.Length - 1)
                {
                    builder.Append("\n").Append("\t").Append(toArray[i]).Append("\n").Append("]");
                }
                else
                {
                    builder.Append("\n").Append("\t").Append(toArray[i]).Append(",");
                }
            }

            return builder.ToString();

        }
    }
}
