using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Homework05.Lib;

namespace Homework05 {
    class Program {
        static void Main (string[] args) {
            var getLED = new LightingControl ();
            var input = "Run";
            getLED.SetLED ();
            while (!string.IsNullOrWhiteSpace (input)) {
                System.Console.WriteLine (getLED.DisplayLEDOnScreen (input));
                Console.Write ("Please choose LED to turn On/Off:");
                input = Console.ReadLine ().ToUpper ();
            }
            Console.Write ("=============== Exit... ===============");
        }
    }
}