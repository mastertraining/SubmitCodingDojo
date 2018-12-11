using System;
using Homework02.classlib;

namespace Homework02.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Number : ");
            var text = Console.ReadLine();
            var multiplier = new TextMultiplier();
            var result = multiplier.GetFormattedString(text);
            Console.Write("{0}", result);
        }
    }
}
