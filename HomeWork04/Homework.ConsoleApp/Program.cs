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
            var sut = new Homework04();
            var newText = sut.GetDivisibleBy5Text(text);
            Console.WriteLine(newText);
        }
    }
}