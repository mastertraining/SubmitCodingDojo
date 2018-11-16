using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork01.lib
{
    public class Homework03 : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            //var upper = text.Select(x => x.ToUpper());
            return text;
        }
    }
}
