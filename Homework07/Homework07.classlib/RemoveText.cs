using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework7.classlib
{
    public class RemoveText : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var removeText = new StringBuilder();
            var SplitString = text.Split(' ').Distinct();
            var result = SplitString.OrderBy(it => it);
            var JoinString = String.Join(" ", result);

            return removeText.Append(JoinString).ToString();
        }
    }
}
