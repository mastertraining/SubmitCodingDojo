using System;

namespace Homework14.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Homework14();
            while (true)
            {
                var input = Console.ReadLine();
                var result = svc.GetGameResult(int.Parse(input));
                Console.WriteLine(result);
            }
        }
    }
}
