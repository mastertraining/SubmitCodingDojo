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
            prm.defaultLED();
            Console.WriteLine(prm.DisplayLEDOnScreen("5"));;

        }

        public void defaultLED() 
        {
            LEDs = new List<string>(new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" });
            noLEDs = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
        }

        public string DisplayLEDOnScreen(string ledNo)
        {
            ReadYaml();
            SetAppConfigurations(getConfig[0], getConfig[1], int.Parse(getConfig[2]));
            ledNo = ledNo.ToUpper();
            
            for (int i = 0; i < 10; ++i)
            {
                if (ledNo == noLEDs[i])
                {
                    LEDs[i] = (LEDs[i] == "[ ]")? configOn : configOff;
                }
            }

            string rsLEDs = String.Join(configSpace, noLEDs);  
            string rsNoLEDs = string.Join(configSpaceNo, LEDs);

            saveState = new StringBuilder()
            .AppendLine(rsLEDs).Append(" ")
            .Append(rsNoLEDs).ToString();

            return saveState;
        }

        public void ReadYaml() 
        {
            fileYamlPath = @"config.yaml";
            var read = new StreamReader(fileYamlPath);
            var deserializer = new DeserializerBuilder().Build();
            var yamlObject = deserializer.Deserialize(read);
            var buildToJson = new SerializerBuilder()
                .JsonCompatible()
                .Build();
             var json = buildToJson.Serialize(yamlObject);
            var reviseJson = json.Replace("-", "");
            var jsonToObj = JsonConvert.DeserializeObject<ConfigLED>(reviseJson);
            var serializer = new YamlDotNet.Serialization.Serializer();
             using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, jsonToObj);
                var yaml = writer.ToString();
                getConfig = yaml.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            config.Add(getConfig[0].Substring(config[0].Length - 1, 1));
            config.Add(getConfig[1].Substring(config[1].Length - 1, 1));
            config.Add(getConfig[2].Substring(config[2].Length - 1, 1));
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
                var subStringNewLine = data.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var listLED = subStringNewLine[0].Split(' ').ToList();
                for (int i = 0; i < LEDs.Count; i++)
                {
                    if (listLED[i] == "[*]")
                    {
                        listLED[i] = "[ ]";
                        LEDs[i] = listLED[i];
                    }
                    else
                    {
                        LEDs[i] = listLED[i];
                    }
                }
                data = data.Replace("[*]", "[ ]");
            }
            else
            {
                data = "NoFile";
            }
            return data;
        }

        public void SaveCurrentState()
        {
            filePath = @"SaveState.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                var txt = saveState.Replace("[ ]", "[*]");
                writer.Write(txt);
            }
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            configOn = new StringBuilder("[").Append(onSymbol).Append("]").ToString();
            configOff = new StringBuilder("[").Append(offSymbol).Append("]").ToString();

            configSpace = new StringBuilder().Insert(0, " ", spacing).ToString();
            configSpaceNo = new StringBuilder().Insert(0, " ", int.Parse(config[2] + 2)).ToString();
        }
    }
}