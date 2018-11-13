using System;
using System.Text;
using homework01.lib;

namespace homework01.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text : ");
            var text = Console.ReadLine();
            var sut = new TextSorting();
            var sort = sut.SortByAlphabetical(text);
            var builder = new StringBuilder();
            builder.Append("Result: ").Append(sort);
            Console.WriteLine(builder);
        }
    }
}
