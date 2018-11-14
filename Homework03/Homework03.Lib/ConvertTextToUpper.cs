using System;
using System.Linq;
using System.Collections.Generic;

namespace Homework03.Lib
{
    public class ConvertTextToUpper : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            return text.Select(x => x.ToUpper());
        }
    }
}
