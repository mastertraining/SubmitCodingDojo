using System;

namespace SortingAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input some word");
            string input = Console.ReadLine();
            
            var split = input.Split(",");
            for (int i = 0; i < split.Length; i++)
            {
                // Console.WriteLine("The output should be:");
                System.Console.WriteLine(split[i]);
            }

           



              //พี่เอ้ ตัด"," ออก
            // string inputs = "hello world, this is a book, bla blabla";
            // var split = inputs.Split(',');
            // for (int i = 0; i < split.Length; i++)
            // {
            //     System.Console.WriteLine(split[i]);
            // }


            // //string[] words = new string[] { "bbb", "aa",  "c" };
            // string inputs = "hello world, this is a book, bla blabla";
            // var split = inputs.Split(',');
            // //var result = String.Join("-", split); //replace

            // //System.Console.WriteLine(result);
            // //var result = words.OrderBy(x => x).ToArray();
            // //Array.Sort(words);
            // for (int i = 0; i < split.Length; i++)
            // {
            //     System.Console.WriteLine(split[i]);
            // }


        }
    }
}
