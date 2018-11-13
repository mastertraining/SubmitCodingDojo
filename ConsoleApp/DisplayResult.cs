using Homework01.Lib;
using Homework02.Lib;
using System;

namespace DojoDay01.Cons
{
    class DisplayResult
    {
        const string homework01Input = "without,hello,bag,world";
        const string homework02Input = "34,67,55,33,12,28";

        static void Main(string[] args)
        {
            Console.WriteLine("Dojo day 1");
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Homework01 : Sort by alphabetical");
            Console.WriteLine("Input  : {0}", homework01Input);
            Console.WriteLine("Result : {0}", GetHomework01Result(homework01Input));
            Console.WriteLine(new string('=', 40));

            Console.WriteLine("Homework02 : Get formatted string");
            Console.WriteLine("Input  : {0}", homework02Input);
            Console.WriteLine("Result : \n{0}", GetHomework02Result(homework02Input));
            Console.WriteLine(new string('=', 40));
        }

        public static string GetHomework01Result(string inputString)
        {
            var sortingSvc = new TextSorting();
            var result = sortingSvc.SortByAlphabetical(inputString);
            return result;
        }

        public static string GetHomework02Result(string inputString)
        {
            var textMultiplierSvc = new TextMultiplier();
            var result = textMultiplierSvc.GetFormattedString(inputString);
            return result;
        }
    }
}
