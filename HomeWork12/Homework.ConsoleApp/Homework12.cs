using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework.ConsoleApp
{
    public class Homework12 : IHomework12
    {
        public char FirstDuplicateCharactor(string text)
        {
            var word = text.ToArray().GroupBy(it => it).FirstOrDefault(it => it.Count() > 1);
            return word == null ? '-' : word.Key;
        }

        public char FirstNotDuplicateCharactor(string text)
        {
            var word = text.ToArray().GroupBy(it => it).FirstOrDefault(it => it.Count() == 1);
            return word == null ? '-' : word.Key;
        }
    }
}