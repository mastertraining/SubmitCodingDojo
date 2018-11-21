using System;
using System.Linq;

namespace Homework07
{
    public class Homework07Logic : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var result = text.Split(' ').OrderBy(it => it).Distinct();
            return string.Join(" ", result);
        }
    }
}