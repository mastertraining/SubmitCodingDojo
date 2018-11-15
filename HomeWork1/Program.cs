using System;
using System.Linq;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(','); 
            Array.Sort<string>(input); 
            Console.WriteLine(string.Join(',', input));
        }
    }
}
