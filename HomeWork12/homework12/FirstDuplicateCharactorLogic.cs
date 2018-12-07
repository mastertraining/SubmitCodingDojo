using System;
using System.Linq;

namespace homework12
{
    public class FirstDuplicateCharactorLogic : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var qry = text.GroupBy(it => it).FirstOrDefault(it => it.Count() > 1);
            var result = qry == null ? '-' : qry.Key;
            return result;
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var qry = text.GroupBy(it => it).FirstOrDefault(it => it.Count() == 1);
            var result = qry == null ? '-' : qry.Key;
            return result;
        }
    }
}
