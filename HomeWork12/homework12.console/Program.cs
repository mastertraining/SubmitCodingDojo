using System;
using homework12.lib;

namespace homework12.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Hello Welcome to FirstCharactor analysis (HomeWork 12){Environment.NewLine}Please input string: ");
            var text = Console.ReadLine();
            var textComparison = new Homework12();
            Console.WriteLine($"First duplicate charactor is: {textComparison.FirstDuplicateCharactor(text)}");
            Console.WriteLine($"First not duplicate charactor is: {textComparison.FirstNotDuplicateCharactor(text)}");
        }
    }
}
