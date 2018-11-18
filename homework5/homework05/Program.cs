using System;

namespace homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]");
            Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
            string input = Console.ReadLine();
           if (input == "1") 
           {
               System.Console.WriteLine("[!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]");
               Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
           }
            if (input == "2") 
           {
               System.Console.WriteLine("[ ] [!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]");
               Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
           }
             if (input == "3") 
           {
               System.Console.WriteLine("[ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ] [ ]");
               Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
           }
             if (input == "4") 
           {
               System.Console.WriteLine("[ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ] [ ]");
               Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
           }
             if (input == "5") 
           {
               System.Console.WriteLine("[ ] [ ] [ ] [ ] [!] [ ] [ ] [ ] [ ] [ ]");
               Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
           }
             if (input == "6") 
           {
               System.Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [!] [ ] [ ] [ ] [ ]");
               Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
           }
             if (input == "7") 
           {
               System.Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [!] [ ] [ ] [ ]");
               Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
           }
             if (input == "8") 
           {
               System.Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [!] [ ] [ ]");
               Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
           }
             if (input == "9") 
           {
               System.Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!] [ ]");
               Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
           }
             if (input == "a" || input == "A") 
           {
               System.Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [!]");
               Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");
           }
        }
    }
}
