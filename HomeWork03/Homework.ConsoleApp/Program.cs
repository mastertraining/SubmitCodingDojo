using System;
using System.Collections.Generic;

namespace Homework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input amount : ");
            var amount = int.Parse(Console.ReadLine());
            var text = new List<string>();
            for (int i = 0; i < amount; i++)
            {
                Console.Write($"#{i+1} : ");
                text.Add(Console.ReadLine());
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