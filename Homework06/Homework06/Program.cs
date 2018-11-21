using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Homework06.Lib;
using Newtonsoft.Json;
using YamlDotNet.Core;
using YamlDotNet.Serialization;

namespace Homework06 {

    class ConfigLightLED {
        public string onsymbol { get; set; }
        public string offsymbol { get; set; }
        public string spaces { get; set; }
    }
    class Program {
        static void Main (string[] args) {
            var call = new LightingControl ();
            var input = "Run";
            call.SetLED ();
            var getYamlFile = call.LoadState ();
            var newYamlFile = getYamlFile.Split (new string[] { Environment.NewLine, "onsymbol: ", "offsymbol: ", "spaces: " }, StringSplitOptions.RemoveEmptyEntries);
            var onSymbol = newYamlFile[0];
            var offSymbol = newYamlFile[1];
            var spacing = string.Join ("", newYamlFile[2].Split (','));
            var spacingConvertInt = int.Parse (spacing);

            call.SetAppConfigurations (onSymbol, offSymbol, spacingConvertInt);
            call.FirstLoad (onSymbol, offSymbol, spacingConvertInt);
            while (!string.IsNullOrWhiteSpace (input)) {
                System.Console.WriteLine (call.DisplayLEDOnScreen (input));
                Console.Write ("Please choose LED to turn On/Off:");
                input = Console.ReadLine ().ToUpper();
                if (input == "SAVE") {
                    call.SaveCurrentState();
                    break;
                }
            }
        }
    }
}