using HomeWirk.lib.Contract;
using HomeWork01.lib;
using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var datawork01 = "without,hello,bag,world";
            var datawork02 = "34,67,55,33,12,28";
            var textSort = new TextSort();
            var data01 = textSort.SortByAlphabetical(datawork01);
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("HomeWork01");
            Console.WriteLine("Data01 : "+ datawork01);
            Console.WriteLine(data01);
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("HomeWork02");
            var textMultiplier = new TextMultiplier();
            var data02 = textMultiplier.GetFormattedString(datawork02);
            Console.WriteLine("Data02 : " + datawork02);
            Console.WriteLine(data02);
        }
    }
}
