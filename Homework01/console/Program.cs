using System;


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Input (ex.:without,hello,bag,world) :");
            string input = Console.ReadLine();
            homework01 hm1 = new homework01();
            var result = hm1.SortByAlphabetical(input);
            Console.WriteLine(result);
        }
    }

