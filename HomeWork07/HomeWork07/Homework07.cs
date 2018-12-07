using HomeWork07;
using System.Linq;

namespace Homework07
{
    public class Homework07 : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var textList = text.Split(' ').ToList();
            textList = textList.Distinct().OrderBy(it => it).ToList();
            return string.Join(" ", textList);
        }
    }
}
