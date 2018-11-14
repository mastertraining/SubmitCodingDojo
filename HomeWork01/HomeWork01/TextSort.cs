using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{
    class Program
    {
        public static void Main(string[] args)
        {
            var data = new TextSort();
            var result = data.SortByAlphabetical("without,hello,bag,world  ");
            Console.WriteLine(result);
            var xxx = GetHomework01Result("without,hello,bag,world  ");
            Console.WriteLine(xxx);
        }
        public static string GetHomework01Result(string inputString)
        {
            var sortingSvc = new TextSorting();
            var result = sortingSvc.SortByAlphabetical(inputString);
            return result;
        }
    }
}
