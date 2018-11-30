using System;

namespace hw12
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var word = new logic();
            var result = word.FirstDuplicateCharactor(text);
            var results = word.FirstNotDuplicateCharactor(text);
            System.Console.WriteLine($"First duplicate charactor is: {result}");
            System.Console.WriteLine($"First not duplicate charactor is: {results}");
        }
    }
}
