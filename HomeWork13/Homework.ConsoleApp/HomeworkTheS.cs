using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework.ConsoleApp
{
    public class HomeworkTheS : IHomework13
    {
        public int Homework13(IEnumerable<int> numbers)
        {
            var numbers99 = numbers.Select(it => it.ToString()).Where(it => Check99(it));
            return numbers99.Count();
        }

        public bool Check99(string number)
        {
            return number.Contains("99") && !number.Contains("9999") && (!number.Contains("999") || number.Count() == 6 && number.StartsWith("99") && number.EndsWith("99"));
        }
    }
}