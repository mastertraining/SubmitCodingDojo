using System;
using Homework12classlib;

namespace Homwork12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input somthing");
            string text = Console.ReadLine();

            var logic = new Logic();
            var resultDuplicate = logic.FirstDuplicateCharactor(text);
            //  var resultNotDuplicate = logic.FirstNotDuplicateCharactor(text);

            Console.WriteLine($"First duplicate charactor is: {resultDuplicate}");

            // Console.WriteLine($"First not duplicate charactor is: {resultNotDuplicate}");
        }
    }
}
