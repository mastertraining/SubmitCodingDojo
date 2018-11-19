using System;

namespace Homework07
{
    class ProgramHomework07
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Please enter your word"); 
           var input = System.Console.ReadLine();

           var a = new Homework07Logic();
           var result = a.RemoveAndSortTextByAlphabetical(input);
           
           System.Console.WriteLine(result);
        }
    }
}
