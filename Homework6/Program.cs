using System;
using System.IO;
using System.Text;
using System.Linq;
using YamlDotNet.Serialization;
using System.Collections.Generic;
using YamlDotNet.RepresentationModel;
using Newtonsoft.Json;

namespace Homework6
{
    class Program: IHomework06
    {
        private string fileYamlPath { get; set; }
        public List<string> LEDs { get; set;}
        public List<string> noLEDs { get; set;}
        public string configOn { get; set; }
        public string configOff { get; set; }
        public string configSpace { get; set; }
        public string configSpaceNo { get; set; }
        public List<string> config { get; set; }
        public List<string> getConfig { get; set; }
        public string saveState { get; set; }
        public string filePath { get; set; }


        static void Main() {
            var prm = new Program();
            prm.setLED();
            prm.DisplayLEDOnScreen("a");
            prm.DisplayLEDOnScreen("9");
            prm.DisplayLEDOnScreen("8");
            prm.SaveCurrentState();
            Console.WriteLine(prm.saveState);;
        }

        public void setLED() 
        {
            LEDs = new List<string>(new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" });
            noLEDs = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
        }

        public string DisplayLEDOnScreen(string ledNo)
        {
            ReadYaml();
            SetAppConfigurations("*", "_", 3);
            ledNo = ledNo.ToUpper();
            
            for (int i = 0; i < 10; ++i)
            {
                if (noLEDs[i] == ledNo)
                {
                    LEDs[i] = (LEDs[i] == configOff)? configOn : configOn;
                }
                else
                {

                }
            }

            string rsLEDs = String.Join(configSpace, LEDs);  
            string rsNoLEDs = string.Join(configSpaceNo, noLEDs);

            saveState = new StringBuilder()
            .AppendLine(rsLEDs).Append(" ")
            .Append(rsNoLEDs).ToString();

            return saveState;
        }

        public void ReadYaml() 
        {
        }

        public string LoadState()
        {
            string data;
            filePath = @"SaveState.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    data = reader.ReadToEnd();
                }
            }
            else
            {
                data = "No Such that File";
            }

            return data;
        }

        public void SaveCurrentState()
        {
            filePath = @"SaveState.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(saveState);
            }
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            configOn = new StringBuilder("[").Append(onSymbol).Append("]").ToString();
            configOff = new StringBuilder("[").Append(offSymbol).Append("]").ToString();

            configSpace = new StringBuilder().Insert(0, " ", spacing).ToString();
            configSpaceNo = new StringBuilder().Insert(0, " ", 5).ToString();
        }
    }
}