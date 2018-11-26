using System;


    class Program
    {
        static void Main(string[] args)
        {
            homework01 hm1 = new homework01();
            var result = hm1.SortByAlphabetical("without,hello,bag,world");
            Console.WriteLine(result);
        }
    }

