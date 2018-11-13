using System;

namespace TextMultiplierConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var sut = new TextMultiplier.TextMultiplier();
            var input = "34,67,55,33,12,28";
            var formmattedText = sut.GetFormattedString(input);
            Console.WriteLine(formmattedText);
            Console.Read();
        }
    }
}
