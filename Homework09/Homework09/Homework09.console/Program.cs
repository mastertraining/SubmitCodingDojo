using System;

namespace Homework09.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Homework09();
            while (true)
            {
                Console.Write("Please input a product key: ");
                svc.GetProductById(Console.ReadLine());
                svc.DisplayPOS();
            }
        }
    }
}
