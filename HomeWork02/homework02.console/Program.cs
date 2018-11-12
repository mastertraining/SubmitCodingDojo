using System;
using homework02.lib;

namespace homework02.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Welcome to TextMultiplier analysis (HomeWork 02)\nWhich text would you want to multiplier?:");
            var text = Console.ReadLine();
            var textMultiplier = new TextMultiplier();
            var result = textMultiplier.GetFormattedString(text);
            System.Console.WriteLine($"Result:\n{result}");
        }
    }
}
