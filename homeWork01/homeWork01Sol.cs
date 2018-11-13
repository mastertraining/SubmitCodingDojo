using System;
using System.Text;
namespace homeWork01
{
    public class homeWork01Sol : ITextSorting
    {

        public string SortByAlphabetical(string text)
        {
            var split = text.Split(',');

            Array.Sort(split);
            // var result = String.Join(",", split);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < split.Length; i++)
            {
                builder.Append(",").Append(split[i]);

            }

            return builder.ToString();
        }
    }
}
