using System;
using System.Text;
using System.Linq;

namespace Homework1.classlib
{
    public class StringSort : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var builder = new StringBuilder();
            var SplitString = text.Split(',');
            var wordsort = SplitString.OrderBy(it => it).ToArray();
            var result = String.Join(",", SplitString);

            return builder.Append(result).ToString();

           
        }

    }
}
