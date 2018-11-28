using System;
using homework04.lib;

namespace homework04.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Welcome to GetDivisibleBy5Text analysis (HomeWork 04)\nWhich text would you want to divisible by 5 Text?: ");
            var text = Console.ReadLine();
            var homework = new Homework04();
            var result = homework.GetDivisibleBy5Text(text);
            System.Console.WriteLine($"Result: {result}");
        }
    }
}
