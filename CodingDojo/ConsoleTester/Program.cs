using Homework_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            ITextMultiplier ITM = new TextMultiplier();
            var str = "[\n\t374,\n\t737,\n\t605,\n\t363,\n\t132,\n\t308\n]";
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
