using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace HomeWork6.classlib
{
    public class HomeWork6ClassLib : IHomework06
    {
        public string filePath { get; set; }
        public string saveStateLED { get; set; }
        public string saveMessage { get; set; }
        public List<string> LED { get; set; }
        public List<string> noLED { get; set; }
        public void defaultLED()
        {
            LED = new List<string>(new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" });
            noLED = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
        }
        public string DisplayLEDOnScreen(string ledNo)
        {
            var ledNoUpper = ledNo.ToUpper();
            for (int i = 0; i < noLED.Count; i++)
            {
                if (ledNoUpper == noLED[i])
                {
                    if (LED[i] == "[ ]")
                    {
                        LED[i] = "[!]";
                    }
                    else
                    {
                        LED[i] = "[ ]";
                    }
                }
            }
            var listKeyLed = String.Join("   ", noLED);
            var listValueLed = String.Join(" ", LED);
            var sb = new StringBuilder();
            var resultDisplayLed = sb.AppendLine(listValueLed).Append(" ").Append(listKeyLed).ToString();
            saveStateLED = resultDisplayLed;

            return resultDisplayLed;
        }

        public string LoadState()
        {
            string resultFormRead;
            filePath = @"SaveState.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    resultFormRead = reader.ReadToEnd();
                }
                var subStringNewLine = resultFormRead.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var listLED = subStringNewLine[0].Split(' ').ToList();
                for (int i = 0; i < LED.Count; i++)
                {
                    if (listLED[i] == "[*]")
                    {
                        listLED[i] = "[ ]";
                        LED[i] = listLED[i];
                    }
                    else
                    {
                        LED[i] = listLED[i];
                    }
                }
                resultFormRead = resultFormRead.Replace("[*]", "[ ]");
            }
            else
            {
                resultFormRead = "NoFile";
            }
            return resultFormRead;
        }

        public void SaveCurrentState()
        {
            filePath = @"SaveState.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                var txt = saveStateLED.Replace("[ ]", "[*]");
                writer.Write(txt);
            }
            saveMessage = "Current state had been saved!";
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            throw new NotImplementedException();
        }
    }
}
