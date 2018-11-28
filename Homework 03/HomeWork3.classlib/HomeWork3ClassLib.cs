using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork3.classlib
{
    public class HomeWork3ClassLib : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            var listUpperCase = text.Select(element => element.ToUpper());
            return listUpperCase;
        }
    }
}
