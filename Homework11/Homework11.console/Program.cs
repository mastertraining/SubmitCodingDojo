using System;

namespace Homework11.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Homework11();
            var result = svc.GetReadWordOfNumber(7302);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
