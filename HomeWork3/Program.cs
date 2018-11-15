using System;
using System.Linq;
using System.Collections.Generic;

namespace HomeWork3
{
    class Program : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        { List<string> allupper = new List<string>(){}; foreach(var val in text) allupper.Add(val.ToUpper()); return allupper; }
    }
}
