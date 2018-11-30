using HW07.lib;
using System;

namespace Homework07
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = "hello world and practice makes perfect and hello world again";
            var text = new Homework();
            var result = text.RemoveAndSortTextByAlphabetical(data);
            Console.WriteLine(result);
        }
    }
}
