using System;
using Homework_classlib;

namespace Homework_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw12 = new Homework12();
            var text = "start";

            do
            {
                Console.Write("Input: ");
                text = Console.ReadLine();
                var duplicate = hw12.FirstDuplicateCharactor(text);
                var notDuplicate = hw12.FirstNotDuplicateCharactor(text);
                Console.WriteLine("Output: ");
                Console.WriteLine("First duplicate charactor is: {0}", duplicate);
                Console.WriteLine("First not duplicate charactor is: {0}", notDuplicate);
            } while (!(string.IsNullOrEmpty(text)));
        }
    }
}