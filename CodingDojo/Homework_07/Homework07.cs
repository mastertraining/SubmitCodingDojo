using System.Linq;

namespace Homework_07
{
    public class Homework07 : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var textArray = text.Split(" ");
            var distinctTexts = textArray.Distinct().OrderBy(it => it);
            return string.Join(" ", distinctTexts);
        }
    }
}
