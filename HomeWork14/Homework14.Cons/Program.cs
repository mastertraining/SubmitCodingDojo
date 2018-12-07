using Homework14.Lib;
using System;

namespace Homework14.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Lib.Homework14();
            Console.Write(svc.GetResultString());
            while (true)
            {
                var input = Console.ReadLine();
                Console.WriteLine();
                Console.Write(svc.PlayAGame(input));
            }
        }
    }
}
