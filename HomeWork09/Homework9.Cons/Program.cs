using Homework9.Lib;
using System;

namespace Homework9.Cons
{
    class Program
    {

        static void Main(string[] args)
        {
            var svc = new Homework09();
            svc.CreateMockProductIfFileNotExists();

            while (true)
            {
                Console.Write(svc.GetPrintString());
                var key = Console.ReadLine();
                if (!svc.AddProductByKey(key))
                {
                    Console.WriteLine(svc.NotFoundProductText);
                };
                Console.WriteLine();
            }
        }
    }
}
