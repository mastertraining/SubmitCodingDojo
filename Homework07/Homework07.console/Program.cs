using System;
using System.Text;
using Homework7.classlib;

namespace Homework07.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            var stringSort = new RemoveText();
            string words;
            string allwords;

            Console.Write("Input Text: ");
            words = Console.ReadLine();

            allwords = builder.Append(words).ToString();
            var result = stringSort.RemoveAndSortTextByAlphabetical(allwords);
            Console.Write(result);
        }
    }
}
