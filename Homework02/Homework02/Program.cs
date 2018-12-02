using System;

using Homework02.Lib;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            //34,67,55,33,12,28
            var format = new TextMultiplier();
            Console.Write("Input Your Text: ");
            string text = Console.ReadLine();
            var formatString = format.GetFormattedString(text);
            Console.WriteLine(formatString);
        }
    }
}
