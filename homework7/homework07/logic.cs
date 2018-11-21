using System;
using System.Linq;

namespace homework07
{
    public class logic : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var split = text.Split(' ');
            var sort = split.OrderBy(it => it);
            var word = sort.Distinct();
            var result = string.Join(" ", word);
            return result;
          
        }
    }
}
