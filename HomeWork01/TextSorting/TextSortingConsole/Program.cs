using System;

namespace TextSortingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var sut = new TextSorting.TextSorting();
            var input = "without,hello,bag,world";
            var orderdText = sut.SortByAlphabetical(input);
            Console.WriteLine(orderdText);
        }
    }
}
