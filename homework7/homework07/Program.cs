using System;
using System.Linq;

namespace homework07
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var g = new logic();
            var f = g.RemoveAndSortTextByAlphabetical(a);
            System.Console.WriteLine(f);

        }
    }
}
