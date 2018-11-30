using System;
using System.Linq;


namespace hw12ClassLib
{
    public class Homework12 : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var groupText = text.GroupBy(it => it).FirstOrDefault(it => it.Count() > 1);
            var result = groupText != null ? groupText.First() : '-';

            return result;

        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var groupText = text.GroupBy(it => it).FirstOrDefault(it => it.Count() == 1);
            var result = groupText != null ? groupText.First() : '-';

            return result;
        }
    }
}
