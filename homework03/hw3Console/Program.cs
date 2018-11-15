using System;
using System.Collections.Generic;
using hw3ClassLib;

namespace hw3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new List<string>();

            while (true)
            {
                Console.Write("Input word : ");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                text.Add(input);
            }
            
            var sut = new Homework03();
            var newText = sut.CapitalizedText(text);
            foreach (var item in newText)
            {
                Console.WriteLine(item);
            }

        }
    }
}
