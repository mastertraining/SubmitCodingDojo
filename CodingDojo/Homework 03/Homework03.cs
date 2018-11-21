using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_03
{
    public class Homework03 : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text) => text.Select(it => it.ToUpper());
    }
}
