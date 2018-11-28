using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using HomeWork2.classlib;

namespace HomeWork2.console
{
    class ProgramSortNumber
    {
        static void Main(string[] args)
        {
            var sortNumber = new SortNumber();
            Console.Write("Enter Number : ");
            string number = Console.ReadLine();
            // var resultSort = sortNumber.GetFormattedString("34,67,55,33,12,28");
            var resultSort = sortNumber.GetFormattedString(number);
            Console.Write(resultSort);

        }
    }
}
