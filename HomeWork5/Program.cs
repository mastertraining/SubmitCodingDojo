using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Program: IHomework05
    {
        Dictionary<char, int> g = new Dictionary<char, int>
        {
            {'1', 1}, {'2', 1},
            {'3', 1}, {'4', 1},
            {'5', 1}, {'6', 1},
            {'7', 1}, {'8', 1},
            {'9', 1}, {'A', 1},
        };
        StringBuilder LEDscreen = new StringBuilder();
        static void Main()
        {
            Program prm = new Program();
            Console.WriteLine(prm.DisplayLEDOnScreen("1"));
        }
        
        static StringBuilder ScreenBuilder() 
        {
            StringBuilder sb = new StringBuilder("");

            return sb;
        }
        public string DisplayLEDOnScreen(string ledNo = "")
        {
            this.LEDscreen = ScreenBuilder();
            char idx = (ledNo.Length > 0)? ledNo[0] : ' ';



            return LEDscreen.ToString();
        }
    }
}