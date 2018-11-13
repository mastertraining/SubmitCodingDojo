using System;
using HomeWork1.classlib;
using System.Text;
using System.Linq;

namespace HomeWork1.console
{
    class SortStringProgram
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var stringSort = new StringSort();
            Console.Write("Enter String : ");
            string inputString = Console.ReadLine();
            // var text = sb.Append("without,hello,bag,world").ToString();
            string text = sb.Append(inputString).ToString();
            var resultSort = stringSort.SortByAlphabetical(text);
            Console.Write(resultSort);
        }
    }
}
