using System;
using System.Linq;
using HomeWork12.classlib;

namespace HomeWork12.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw12 = new HomeWork12ClassLib();
            while (true)
            {
                Console.Write("Please input string:");
                var inputString = Console.ReadLine();
                var firstDuplicate = hw12.FirstDuplicateCharactor(inputString);
                var firstNotDuplicate = hw12.FirstNotDuplicateCharactor(inputString);
                Console.Write($"First duplicate charactor is:{firstDuplicate} \n");
                Console.Write($"First not duplicate charactor is: {firstNotDuplicate} \n");
            }
        }
    }
}
