using System;
using System.Linq;

namespace Homework07
{
    public class Homework07Logic : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var split = text.Split(' ');
            var sorting = split.OrderBy(it => it);
            var result = sorting.Distinct();
            var joined = string.Join(" ", result);

            return joined;
        }
    }
}