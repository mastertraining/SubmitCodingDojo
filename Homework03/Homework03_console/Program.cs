using System;
using Homework03_classlib;

namespace Homework03_console
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input amount : ");
            var amount = int.Parse(Console.ReadLine());
            string[] text = new string[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.Write("{0} : ", i+1);
                text[i] = Console.ReadLine();
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
