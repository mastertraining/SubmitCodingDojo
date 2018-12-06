using System;
using System.Text;
using HomeworkclassLib;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {
            var sn = new Logic();

            var replay = "yes";
            while (replay == "yes")
            {
                // if (replay == "yes")
                // {
                //     Console.WriteLine(sn.StartGame);
                //     Console.Write("Please input a number: ");
                // }
                
                // Console.WriteLine(sn.StartGame);
                 Console.Write("Please input a number: ");
                var input = int.Parse(Console.ReadLine());
                var result = sn.GetGameResult(input);
                Console.WriteLine(result);
            }

        }
    }
}
