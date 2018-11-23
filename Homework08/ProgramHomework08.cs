using System;
using System.Text;

namespace ProgramHomework08
{
    class Program
    {
        static void Main(string[] args)
        {
            //1     /|
            //2    / |
            //3   /__|

        System.Console.WriteLine("Enter your number");
        var input = int.Parse(Console.ReadLine());
        var star = " / ";
        var space = "";
        while (input > 0)
        {   
            space += star;
            input --;
            System.Console.WriteLine(space);
        }
        // for (int i = 0; i < input; i++)
        // {
        //     space += star;
        //      System.Console.WriteLine(space);
        // }

        // โปรแกรมสร้างพีระมิด-while loop
            // Console.WriteLine("how many floor?");
            // int floor = int.Parse(Console.ReadLine());

            // string a = "*";
            // string b = "";

            // while (floor > 0)
            // {
            //    b += a;
            //    Console.WriteLine(b);

            //    floor--;
            
        }
    }
}
