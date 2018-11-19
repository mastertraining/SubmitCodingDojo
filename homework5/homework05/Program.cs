using System;
using System.Linq;
using System.Text;

namespace homework05
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]");
            System.Console.WriteLine(" 1   2   3   4   5   6   7   8   9   A");

            // string a = "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]";
            // string b = "[!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]";
            string number = " 1   2   3   4   5   6   7   8   9   A";
            // var add = new StringBuilder();
            // var aadd = add.Append($"{a}\n{number}");

            // string input = Console.ReadLine();

            string c = "[!] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]";
            var cadd = new StringBuilder();
            var caddd = cadd.Append($"{c}\n{number}");

            var input = Console.ReadLine();
            bool isturnoff = true;

            while (true)
            {

                {
                    // if (isturnoff)
                    {
                        // System.Console.WriteLine(aadd);

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

                        else
                        {
                            // System.Console.WriteLine(caddd);
                            System.Console.WriteLine("Please choose LED to turn On/Off: ");
                        }
                        isturnoff = !isturnoff;
                        input = System.Console.ReadLine();
                    }
                }
                // Console.WriteLine("Exit program");

            }
        }
    }
}


