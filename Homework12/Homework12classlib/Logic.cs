using System;

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
            throw new NotImplementedException();
        }
    }
}
