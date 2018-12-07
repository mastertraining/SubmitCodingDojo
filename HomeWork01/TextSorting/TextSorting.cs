using System;
using System.Linq;

namespace TextSorting
{
    public class TextSorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var splitText = text.Split(',');
            var orderedText = splitText.OrderBy(it => it).ToArray();
            return String.Join(",", orderedText);
        }
    }
}
