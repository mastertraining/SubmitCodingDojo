using HomeWork07;
using System.Linq;

namespace Homework07
{
    public class Homework07 : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var textList = text.Split(' ').ToList();
            var orderedList = textList.GroupBy(x => x).Select(y => y.Key).OrderBy(it => it);
            return string.Join(" ", orderedList);
        }
    }
}
