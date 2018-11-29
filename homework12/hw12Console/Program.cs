using System;
using hw12ClassLib;

namespace hw12Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw12 = new Homework12();
            var input = " ";

            while (true)
            {
                Console.Write("Input: ");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                var duplicate = hw12.FirstDuplicateCharactor(input);
                var notDuplicate = hw12.FirstNotDuplicateCharactor(input);
                Console.WriteLine("Output: ");
                Console.WriteLine($"First duplicate charactor is: {duplicate}");
                Console.WriteLine($"First not duplicate charactor is: {notDuplicate}");
            }
        }
    }
}
