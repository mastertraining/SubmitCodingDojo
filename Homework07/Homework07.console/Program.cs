using System;
using System.Text;
using Homework7.classlib;

namespace Homework07.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var removeText = new StringBuilder();
            var stringSort = new RemoveText();
            string words;
            string allwords;

            Console.Write("Input Text: ");
            words = Console.ReadLine();

            allwords = removeText.Append(words).ToString();
            var result = stringSort.RemoveAndSortTextByAlphabetical(allwords);
            Console.Write(result);
        }
    }
}
