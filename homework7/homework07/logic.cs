using System;
using System.Linq;

namespace homework07
{
    public class logic : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var Split = text.Split(' ');
            var word = Split.OrderBy(it => it);
            var eiei = word.Distinct();
            var result = string.Join(" ", eiei);
            return result;
        }
    }
}
