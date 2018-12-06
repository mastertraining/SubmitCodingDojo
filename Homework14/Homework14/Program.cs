using System;
using System.Text;
using HomeworkclassLib;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {


            // var sn = new Logic();
            //  sn.SetupANewGame();
            // var isnewgame = true;
            // var playagain = "yes";
            // while (playagain == "yes")
            // {

            //        // Console.WriteLine(sn.StartGame);
            //         Console.Write("Please input a number: ");
            //         var input = int.Parse(Console.ReadLine());
            //         // sn.SetupANewGame();
            //         var result = sn.GetGameResult(input);
            //         Console.WriteLine(result);

            //     // else
            //     // {
            //     //       Console.Write("Do you want to try again?: ");
            //     // }                
            //     // isnewgame = !isnewgame;
            //     // playagain = Console.ReadLine();
            // }
            // Console.WriteLine("Good BYE");


            var sn = new Logic();
            sn.SetupANewGame();
            Console.WriteLine(sn.StartGame);
            while (true)
            {
                Console.Write("Please input a number: ");
                var input = int.Parse(Console.ReadLine());
                var result = sn.GetGameResult(input);
                Console.WriteLine(result);
            }

        }
    }
}
