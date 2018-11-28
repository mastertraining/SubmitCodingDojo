using System;
using capitalized.lib;
using System.Collections.Generic;

namespace capitalized.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Input :");
            var input = Console.ReadLine();
            Homework03 hm3 = new Homework03();
            List<string> ans = new List<string>{input};
            var result = hm3.CapitalizedText(ans);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
