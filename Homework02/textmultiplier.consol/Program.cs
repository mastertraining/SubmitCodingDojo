using System;
using TextMultiplier.Lib;

namespace textmultiplier.consol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Input (ex.:34,67,55,33,12,28) :");
            string input = Console.ReadLine();
            Homework02 hm2 = new Homework02();
            var result = hm2.GetFormattedString(input);
            Console.WriteLine(result);
        }
    }
}
