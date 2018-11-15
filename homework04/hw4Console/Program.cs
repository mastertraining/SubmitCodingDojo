using System;
using System.Text;
using hw4ClassLib;

namespace hw4Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text :");
            var text = Console.ReadLine();
            var sut = new Homework04();
            var divBy5 = sut.GetDivisibleBy5Text(text);
            var builder = new StringBuilder();
            builder.Append("Result: ").Append(divBy5);
            Console.Write(builder);
        }
    }
}
