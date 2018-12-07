using System;

namespace Homework10.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new Homework10();
            while (true)
            {
                Console.Write("Please input a product key: ");
                var input = Console.ReadLine();
                if (input == "save") svc.SaveCurrentState();
                else svc.GetProductById(input);
                svc.DisplayPOS();
            }
        }
    }
}
