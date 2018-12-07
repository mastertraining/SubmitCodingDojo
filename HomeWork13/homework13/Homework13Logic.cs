using System;
using System.Collections.Generic;
using System.Linq;

namespace homework13
{
    public class Homework13Logic : IHomework13
    {
        public int Homework13(IEnumerable<int> numbers)
        {
            var number = numbers.Select(it => it.ToString()).Where(it => number(it)).Count();
            return number;
        }
        
    }
}
