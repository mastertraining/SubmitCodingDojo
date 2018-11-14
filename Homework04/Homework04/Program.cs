using System;
using System.Linq;
using Homework04.Lib;

namespace Homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            //0100,0011,1010,1001
            Console.Write("Input Binary Numbers: ");
            var text = Console.ReadLine();
            
            var getDivisible = new DivisibleBy5Text();
            var result = getDivisible.GetDivisibleBy5Text(text);
            Console.WriteLine(result);
        }
    }
}
