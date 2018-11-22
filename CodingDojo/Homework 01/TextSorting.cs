using System.Linq;

namespace Homework_01
{
    public class TextSorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var textArray = text.Split(',').OrderBy(it => it);
            return string.Join(",", textArray);
        }
    }
}
