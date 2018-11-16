using System;

namespace testhome
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var b = new testlogic();
            var result =  b.GetDivisibleBy5Text(text);
            System.Console.WriteLine(result);
        }
    }
}
