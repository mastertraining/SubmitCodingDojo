using System;
using System.Collections.Generic;

namespace Homework03_classlib
{
    public interface IHomework03
    {
        IEnumerable<string> CapitalizedText(IEnumerable<string> text);
    }
}
