using System;

namespace Homework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text : ");
            var text = Console.ReadLine();
            var sut = new TextSorting();
            var newText = sut.SortByAlphabetical(text);
            Console.WriteLine($"Result : {newText}");
        }
    }
}