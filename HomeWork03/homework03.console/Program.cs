using System;
using System.Collections.Generic;
using homework03.lib;

namespace homework03.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Welcome to CapitalizedText analysis (HomeWork 03)\nWhich text would you want to capitalize?: ");
            var text = new List<string>();
            var hasMoreText = true;
            const int MinimumTextCount = 0;
            while (hasMoreText)
            {
                if (text.Count > MinimumTextCount) System.Console.Write("Another one?: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input)) text.Add(input);
                else hasMoreText = false;
            }
            var homework = new Homework03();
            var result = homework.CapitalizedText(text);
            System.Console.WriteLine("There your capitalized text");
            foreach (var item in result) System.Console.WriteLine(item);
        }
    }
}
