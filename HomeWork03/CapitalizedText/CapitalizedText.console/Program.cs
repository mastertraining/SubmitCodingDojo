using System;
using System.Collections.Generic;

namespace CapitalizedText.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputSet = new List<string>();
            var svc = new CapitalizedText.Homework03();
            Console.WriteLine("Please enter words :");
            while (true)
            {
                var words = Console.ReadLine().ToString();
                if (words == string.Empty)
                {
                    break;
                }
                inputSet.Add(words);
            }
            var wordUpper = svc.CapitalizedText(inputSet);
            Console.WriteLine("Result :");
            Console.WriteLine(string.Join("\n",wordUpper));
        }
    }
}
