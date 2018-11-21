using System;
using System.Linq;

namespace HW07.lib
{
    public class Homework : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var data = text.Split(' ').ToList();
            data = data.Distinct().OrderBy(it => it).ToList();
            return string.Join(" ", data);
        }
    }
}
