using System;
using System.Text;
using homework02.lib;

namespace homework02.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text : ");
            var text = Console.ReadLine();
            var sut = new TextMultiplier();
            var sort = sut.GetFormattedString(text);
            var builder = new StringBuilder();
            builder.AppendLine("Result: ").Append(sort);
            Console.Write(builder);

        }
    }
}
