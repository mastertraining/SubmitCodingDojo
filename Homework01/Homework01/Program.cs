using System;
using Homework01.Lib;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            var strSorting = new TextSorting();
            Console.Write("Input Your Text: ");
            string text = Console.ReadLine();
            var textSorting = strSorting.SortByAlphabetical(text);
            Console.WriteLine(textSorting);
        }
    }
}
