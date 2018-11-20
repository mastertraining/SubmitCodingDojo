using System;
using System.Linq;

namespace homework07
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = Console.ReadLine();
            var alphanumerically = new logic();
            var result = alphanumerically.RemoveAndSortTextByAlphabetical(alphabet);
            System.Console.WriteLine(result);

        }
    }
}
