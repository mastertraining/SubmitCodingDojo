using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework03.classlib
{
    public class StringToUpper : IHomework03
    {
        public IEnumerable<string> GetFormattedString(IEnumerable<string> text)
        {
            List<string> data = new List<string>();
            foreach (var item in text)
            {
                data.Add(item.ToUpper());
            }
            return data;
        }
    }
}
