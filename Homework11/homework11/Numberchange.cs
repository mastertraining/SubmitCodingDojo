using System;
using homework11class;
namespace homework11
{
    class Numberchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your number");
            var input = int.Parse(Console.ReadLine());
            var result = new Logic();
            Console.WriteLine(result.GetReadWordOfNumber(input));



        }
    }
}
