using System;
using Homework_classlib;

namespace Homework_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var call = new Homework07();
            Console.Write("Input text: ");
            var text = Console.ReadLine();
            var newText = call.RemoveAndSortTextByAlphabetical(text);
            Console.Write(newText);
        }
    }
}
