using HomeWork12.lib;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Work();
            var result = data.FirstDuplicateCharactor("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ");
            var result2 = data.FirstNotDuplicateCharactor("ZXCZXCVBNMASDFGHJVBNMASZXCVBNMASDFGHJDFGHJ");
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
