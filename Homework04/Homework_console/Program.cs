using System;
using Homework_classlib;
namespace Homework_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var sut = new Homework04();
            Console.Write("Input text : ");
            var text = Console.ReadLine();
            var newText = sut.GetDivisibleBy5Text(text);
            Console.WriteLine(newText);
        }
    }
}
