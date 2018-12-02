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
            Console.Write("Input Row: ");
            var row = Int32.Parse(Console.ReadLine());
            string[] text = new string[row];
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = Console.ReadLine();
            }
            capCharacter.CapitalizedText(text).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
