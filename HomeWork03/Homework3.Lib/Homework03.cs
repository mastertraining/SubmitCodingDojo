using Homework3.Lib.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework3.Lib
{
    public class Homework03 : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            return text.ToList().Select(it => it.ToUpper());
        }
    }
}
