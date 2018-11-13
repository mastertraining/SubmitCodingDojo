using System;
using System.Text;
using Homework1.classlib;


namespace Homework1.console
{
    class SortDataProgram
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            var stringSort = new StringSort();
            string words;
            string allwords;

            Console.Write("");
            words = Console.ReadLine();
            
            allwords = builder.Append(words).ToString();
            var result = stringSort.SortByAlphabetical(allwords);
            Console.Write(result);
        }
    }
}
