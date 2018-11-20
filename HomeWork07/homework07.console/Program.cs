using System;
using homework07.lib;

namespace homework07.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Welcome to RemoveAndSortTextByAlphabetical analysis (HomeWork 07)\nWhich text would you want to rmove and sort text by alphabetical?: ");
            var text = Console.ReadLine();
            var control = new Homework07();
            var result = control.RemoveAndSortTextByAlphabetical(text);
            System.Console.WriteLine($"Result: {result}");
        }
    }
}
