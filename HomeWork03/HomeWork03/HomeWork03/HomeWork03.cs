using System;
using System.Collections.Generic;
using HomeWork01.lib;
using System.Linq;
namespace HomeWork03
{
    public class HomeWork03
    {
        public static void Main(string[] args)
        {
            var text = new Homework03();

            List<string> data = new List<string>();
            data.Add(Console.ReadLine().ToUpper());
            text.CapitalizedText(data).ToList().ForEach(x=> Console.WriteLine(x));
        }
    }
}
