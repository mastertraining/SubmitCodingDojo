using System;
using System.Linq;

namespace homework07
{
    public class RemoveAndSortTextLogic : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var split = text.Split(' ');
            var removeText = split.OrderBy(it => it);
            var removeAndSort = removeText.Distinct();
            var result = string.Join(" ", removeAndSort);
            return result;
        }
    }
}
