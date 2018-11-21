using System;
using System.Collections.Generic;

namespace Homework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text : ");
            var text = Console.ReadLine();
            var sut = new Homework07();
            var newText = sut.RemoveAndSortTextByAlphabetical(text);
            Console.WriteLine(newText);
        }
    }
}