using System;
using System.Linq;

namespace homework07.lib
{
    public class Homework07 : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var isTextValid = !string.IsNullOrWhiteSpace(text);
            if (!isTextValid) return string.Empty;

            var textSplited = text.Trim().Split().Distinct().OrderBy(it => it);
            return string.Join(" ", textSplited);
        }
    }
}
