using System;
using System.Collections.Generic;
using System.Linq;

namespace homework03.lib
{
    public class Homework03 : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            var isValid = text != null && !text.Any(it => string.IsNullOrWhiteSpace(it));
            if (!isValid) return Enumerable.Empty<string>();
            return text.Select(it => it.ToUpper());
        }
    }
}
