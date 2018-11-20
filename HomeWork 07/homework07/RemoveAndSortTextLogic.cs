using System;
using System.Linq;

namespace homework07
{
    public class RemoveAndSortTextLogic : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var split = text.Split(' ');
            var removeAndSortText = split.OrderBy(it => it).Distinct();
            var result = string.Join(" ", removeAndSortText);
            return result;
        }
    }
}
