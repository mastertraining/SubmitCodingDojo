using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> words = new List<string>(input.Split(' '));
            List<string> wordsDis = words.Distinct()
                                        .OrderBy(x => x)
                                        .ToList();

            string output = String.Join(" ", wordsDis.ToArray());

            Console.Write(output);
        }
    }
}
