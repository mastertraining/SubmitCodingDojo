using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace HomeWork6.classlib
{
    public class HomeWork6ClassLib : IHomework06
    {
        public Dictionary<string, string> listLED { get; set; }
        public string saveStateLED { get; set; }
        public List<string> LED { get; set; }
        public List<string> noLED { get; set; }
        public List<string> saveLED { get; set; }
        public void defaultLED()
        {
            LED = new List<string>(new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" });
            noLED = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
            // listLED = new Dictionary<string, string>();
            // listLED.Add("1", "[ ]");
            // listLED.Add("2", "[ ]");
            // listLED.Add("3", "[ ]");
            // listLED.Add("4", "[ ]");
            // listLED.Add("5", "[ ]");
            // listLED.Add("6", "[ ]");
            // listLED.Add("7", "[ ]");
            // listLED.Add("8", "[ ]");
            // listLED.Add("9", "[ ]");
            // listLED.Add("A", "[ ]");
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
            // if (listLED.ContainsKey(ledNoUpper))
            // {
            //     if (listLED[ledNoUpper] == "[ ]")
            //     {
            //         listLED[ledNoUpper] = "[!]";
            //     }
            //     else
            //     {
            //         listLED[ledNoUpper] = "[ ]";
            //     }
            // }
            // var keyLed = listLED.Keys;
            // var valuesLed = listLED.Values;
            // var listKeyLed = String.Join("   ", keyLed);
            // var listValueLed = String.Join(" ", valuesLed);

            var listKeyLed = String.Join("   ", noLED);
            var listValueLed = String.Join(" ", LED);
            var sb = new StringBuilder();
            var resultDisplayLed = sb.AppendLine(listValueLed).Append(" ").Append(listKeyLed).ToString();
            saveStateLED = resultDisplayLed;
            // saveLED = LED;
            return resultDisplayLed;
        }

        public string LoadState()
        {
            var filePath = @"SaveState.txt";
            string resultFormRead;
            using (StreamReader reader = new StreamReader(filePath))
            {
                resultFormRead = reader.ReadToEnd();

            }
            var subStringNewLine = resultFormRead.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var listLED = subStringNewLine[0].Split(' ').ToList();
            var noLED = subStringNewLine[1].Split(' ').ToList();
            // LED = LED.Replace("[*]","[ ]");
            // for (int i = 0; i < 10; i++)
            // {
            //     if (LED[i] == "[*]")
            //     {
            //         LED[i] = "[ ]";
            //         listLED[noLED[i]] = LED[i];
            //     }
            //     else
            //     {
            //         listLED[noLED[i]] = LED[i];
            //     }
            // }
            for (int i = 0; i < LED.Count; i++) {
                if(listLED[i] == "[*]") {
                    listLED[i] = "[ ]";
                    LED[i] = listLED[i];
                }
                else {
                    LED[i] = listLED[i];
                }
            }
            return resultFormRead.Replace("[*]", "[ ]");
        }

        public void SaveCurrentState()
        {
            var filePath = @"SaveState.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                var txt = saveStateLED.Replace("[ ]", "[*]");
                writer.Write(txt);
            }
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            throw new NotImplementedException();
        }
    }
}
