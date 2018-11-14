using System;
using Homework01.classlib;

namespace Homework01.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Text : ");
            var text  = Console.ReadLine();
            var sorttext = new Textsorting();
            var newtext = sorttext.SortByAlphabetical(text);
            Console.WriteLine(newtext);
        }
    }
}
