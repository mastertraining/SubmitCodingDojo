using System;
using homework12;

namespace homework12Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please input string: ");
            var inputString = Console.ReadLine();
            var text = new FirstDuplicateCharactorLogic();
            System.Console.WriteLine($"FirstDuplicateCharactor is: {text.FirstDuplicateCharactor(inputString)}");
            System.Console.WriteLine($"FirstNotDuplicateCharactor is: {text.FirstNotDuplicateCharactor(inputString)}");
        }
    }
}
