using System;
using System.Collections.Generic;
using System.Linq;

namespace homework3 
{
    public class workup : IHomework03
    {
        public IEnumerable<string> CapitalizedText(IEnumerable<string> text)
        {
            text = new string []{};
            var word = text.Select(it=> it.ToUpper());
            return word;
           
           
        }
    }

}

