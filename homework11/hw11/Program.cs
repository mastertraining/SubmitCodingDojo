using System;

namespace hw11
{
    class Program
    {
        static void Main(string[] args)
        {
          int input = int.Parse(Console.ReadLine());
          var number  = new logic();
          var result = number.GetReadWordOfNumber(input);
          System.Console.WriteLine(result);
        }
    }
}
