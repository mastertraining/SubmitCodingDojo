using System.Collections.Generic;
namespace Homework03.Lib
{
    public interface IHomework03
    {
        IEnumerable<string> CapitalizedText(IEnumerable<string> text);
    }
}