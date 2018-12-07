﻿using Homework5.Lib.Contract;
using System;

namespace Homework5.Lib
{
    public class Homework05 : IHomework05
    {
        private const string ledStringPlattern = @"[*0] [*1] [*2] [*3] [*4] [*5] [*6] [*7] [*8] [*9]
 1   2   3   4   5   6   7   8   9   A";

        public bool[] Switches { get; set; }

        public Homework05()
        {
            Switches = new bool[] { false, false, false, false, false, false, false, false, false, false };
        }

        private string GetLEDStringFromSwitches()
        {
            var ledString = ledStringPlattern;
            for (int i = 0; i < Switches.Length; i++)
            {
                var switchDisplay = Switches[i] ? "!" : " ";
                ledString = ledString.Replace($"*{i.ToString()}", switchDisplay);
            }
            return ledString;
        }

        public string DisplayLEDOnScreen(string ledNo)
        {
            var index = ledNo.ToUpper() == "A" ? 9 : int.Parse(ledNo) - 1;
            Switches[index] = !Switches[index];
            return GetLEDStringFromSwitches();
        }
    }
}