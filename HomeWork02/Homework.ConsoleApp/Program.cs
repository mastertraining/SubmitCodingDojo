using System;

namespace Homework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input sequence : ");
            var text = Console.ReadLine();
            var sut = new TextMultiplier();
            var newText = sut.GetFormattedString(text);
            Console.WriteLine(newText);
        }
    }
}