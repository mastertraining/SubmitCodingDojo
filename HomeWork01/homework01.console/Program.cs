using System;
using homework01.lib;

namespace homework01.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Welcome to TextSort analysis (HomeWork 01)\nWhich text would you want to sort?:");
            var text = Console.ReadLine();
            var textSorting = new TextSorting();
            var result = textSorting.SortByAlphabetical(text);
            System.Console.WriteLine($"Result: {result}");
        }
    }
}
