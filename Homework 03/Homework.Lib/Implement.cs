using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework.Lib
{
    public class Implement : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            return text.Select(it => it.ToUpper());
        }
    }
}
