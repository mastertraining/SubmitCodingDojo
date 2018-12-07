using System;
using System.Linq;

namespace Homework12classlib
{
    public class Logic : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var returnchar = text.ToCharArray();
            for (int i = 0; i < returnchar.Length; i++)
            {
                for (int j = i + 1; j < returnchar.Length; j++)
                {
                    if (returnchar[i] == returnchar[j])
                    {
                        return returnchar[i];
                    }
                }
            }
            return '-';
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var returnchar = text.ToCharArray();
            var Group = returnchar.GroupBy(it => it);
            var GroupWhere = Group.Where(it => it.Count() == 1);
            var result = GroupWhere.FirstOrDefault();
            if (result == null)
            {
                return '-';
            }
            return result.Key;

        }
    }
}