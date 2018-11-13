using System;

namespace SortingAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Please input some word");
            // string input = Console.ReadLine();
            string input = "hello world,this is a book,bla blabla";

            //split
            var split = input.Split(",");

            //sort
            Array.Sort(split);

            //Join ","
            var addcomma = string.Join(",",split);
            System.Console.Write(addcomma);

        }
    }
}
