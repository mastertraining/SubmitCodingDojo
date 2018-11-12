using System;
using System.Linq;
using System.Text;

namespace homework01.lib
{
    public class TextSorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var isValid = !string.IsNullOrWhiteSpace(text);
            if(!isValid) return string.Empty;

            var textSplited = text.Split(',').ToList();
            var textSorted = textSplited.Select(it => it.Trim()).OrderBy(it => it);
            var sb = new StringBuilder();
            foreach (var item in textSorted)
            {
                sb.Append(item);
                if (item != textSorted.LastOrDefault()) sb.Append(",");
            }
            var result = sb.ToString();
            return result;
        }
    }
}
