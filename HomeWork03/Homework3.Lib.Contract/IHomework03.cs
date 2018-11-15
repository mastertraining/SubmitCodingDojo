using System;
using System.Collections.Generic;

namespace Homework3.Lib.Contract
{
    public interface IHomework03
    {
        IEnumerable<string> CapitalizedText(IEnumerable<string> text);
    }
}
