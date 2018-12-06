using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class Program: IHomework05
    {
        static StringBuilder LEDscreen;
        Dictionary<char, int> GapsMaper = new Dictionary<char, int>
        {
            {'1', 1}, {'2', 5},
            {'3', 9}, {'4', 13},
            {'5', 17}, {'6', 21},
            {'7', 25}, {'8', 29},
            {'9', 33}, {'A', 37},
            {'a', 37}
        };

        static void Main()
        {
            Program prm = new Program();
            LEDscreen = ScreenBuilder();
            while (true)
            {
                Console.WriteLine(prm.DisplayLEDOnScreen());
                Console.Write("Please choose LED to turn On/Off: ");
                string input = Console.ReadLine();
                prm.DisplayLEDOnScreen(input);
            }
        }

        static StringBuilder ScreenBuilder() 
        {
            return new StringBuilder().Insert(0, "[ ]", 10)
                .Replace("][", "] [").Append("\n")
                .Append(" 1   2   3   4   5  ")
                .Append(" 6   7   8   9   A");
        }
        
        public string DisplayLEDOnScreen(string ledNo = "")
        {
            char idx = (ledNo.Length > 0)? ledNo[0] : ' ';

            if (GapsMaper.ContainsKey(idx))
            {
                 if (LEDscreen.ToString()[GapsMaper[idx]] == '!')
                {
                    LEDscreen.Remove(GapsMaper[idx], 1).Insert(GapsMaper[idx], ' ');
                }
                else
                {
                    LEDscreen.Remove(GapsMaper[idx], 1).Insert(GapsMaper[idx], '!');
                }
            }

            return LEDscreen.ToString();
        }
    }
}