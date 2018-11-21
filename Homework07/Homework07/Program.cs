using System;
using System.Linq;
using Homework07.Lib;
namespace Homework07 {
    class Program {
        static void Main (string[] args) 
        {
            var call = new DuplicateWordsAndSorting ();
            var input = Console.ReadLine();
            var result = call.RemoveAndSortTextByAlphabetical(input);
            System.Console.WriteLine(result);
        }
    }
}