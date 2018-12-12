using System;
using System.Linq;
using HomeWork12.classlib;

namespace HomeWork12.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var Duplicate = new HomeWork12ClassLib();
            while (true)
            {
                Console.Write("Please input string:");
                var inputString = Console.ReadLine();
                var firstDuplicate = Duplicate.FirstDuplicateCharactor(inputString);
                var firstNotDuplicate = Duplicate.FirstNotDuplicateCharactor(inputString);
                Console.Write($"First duplicate charactor is:{firstDuplicate} \n");
                Console.Write($"First not duplicate charactor is: {firstNotDuplicate} \n");
            }
        }
    }
}