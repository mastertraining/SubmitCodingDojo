using System;
using System.Linq;
using System.Collections.Generic;
using Homework03.Lib;

namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            var capCharacter = new ConvertTextToUpper();
            List<string> text = new List<string>();
            Console.Write("Input Row: ");
            var row = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < row; i++)
            {
                text.Add(Console.ReadLine());
            }
            capCharacter.CapitalizedText(text).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
