using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var homework12 = new Homework12();
            Console.Write("Please input string: ");
            var text = Console.ReadLine();
            var duplicateCharactor = homework12.FirstDuplicateCharactor(text);
            var notDuplicateCharactor = homework12.FirstNotDuplicateCharactor(text);
            Console.WriteLine($"First duplicate charactor is: {duplicateCharactor}");
            Console.WriteLine($"First duplicate charactor is: {notDuplicateCharactor}");
        }
    }
}