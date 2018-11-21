using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework.ConsoleApp
{
    public class Homework07 : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var separator = ' ';
            var result = text.Split(separator).OrderBy(it => it).Distinct();
            return string.Join(separator, result);
        }
    }
}