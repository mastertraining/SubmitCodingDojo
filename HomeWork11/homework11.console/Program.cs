using System;
using homework11.lib;

namespace homework11.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Hello Welcome to GetReadWordOfNumber analysis (HomeWork 11){Environment.NewLine}Please input number: ");
            var input = Console.ReadLine();
            int.TryParse(input, out int intputNumber);
            
            var reader = new Homework11();
            var result = reader.GetReadWordOfNumber(intputNumber);
            Console.WriteLine($"Result: {result}");
        }
    }
}
