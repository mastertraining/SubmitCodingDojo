using System;
using System.Collections.Generic;
using System.Linq;

namespace capitalized.lib
{
    public class Homework03 : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            var result = text.Select(it => it.ToUpper());
            return result;
        }
    }
}
