using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;
using Newtonsoft.Json;

namespace HomeWork6.classlib
{
    public class HomeWork6ClassLib : IHomework06
    {
        public string filePath { get; set; }
        public string fileYamlPath { get; set; }
        public string saveStateLED { get; set; }
        public List<string> LED { get; set; }
        public List<string> noLED { get; set; }
        public List<string> config { get; set; }
        public string configOn { get; set; }
        public string configOff { get; set; }
        public string configSpaces { get; set; }
        public string configSpaceNo { get; set; }
        public List<string> getConfig { get; set; }
        public List<string> statusLED { get; set; }
        public string getYaml { get; set; }

        public void defaultLED()
        {
            var readYaml = ReadYaml();
            getConfig = new List<string>();
            getConfig = readYaml.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            config = new List<string>();
            config.Add(getConfig[0].Substring(getConfig[0].Length - 1, 1));
            config.Add(getConfig[1].Substring(getConfig[1].Length - 1, 1));
            config.Add(getConfig[2].Substring(getConfig[2].Length - 1, 1));
            SetAppConfigurations(config[0], config[1], int.Parse(config[2]));
            LED = new List<string>(new string[] { configOff, configOff, configOff, configOff, configOff, configOff, configOff, configOff, configOff, configOff });
            statusLED = new List<string>(new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" });
            noLED = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
        }
        public string DisplayLEDOnScreen(string ledNo)
        {
            var ledNoUpper = ledNo.ToUpper();
            for (int i = 0; i < noLED.Count; i++)
            {
                if (ledNoUpper == noLED[i])
                {
                    if (statusLED[i] == "0")
                    {
                        statusLED[i] = "1";
                    }
                    else
                    {
                        statusLED[i] = "0";
                    }
                }
            }
            for (int i = 0; i < statusLED.Count; i++)
            {
                if (statusLED[i] == "0")
                {

                    LED[i] = configOff;
                }
                else
                {
                    LED[i] = configOn;
                }
            }
            var listNoLed = String.Join(configSpaceNo, noLED);
            var listValueLed = String.Join(configSpaces, LED);
            var sb = new StringBuilder();
            var resultDisplayLed = sb.AppendLine(listValueLed).Append(" ").Append(listNoLed).ToString();

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
            saveStateLED = String.Join(" ", statusLED);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(saveStateLED);
            }
        }

        public string ReadYaml()
        {
            fileYamlPath = @"config.yml";
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
                getYaml = yaml;
            }
            return getYaml;
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            var onSymbolSb = new StringBuilder();
            configOn = onSymbolSb.Append("[").Append(onSymbol).Append("]").ToString();
            var offSymbolSb = new StringBuilder();
            configOff = offSymbolSb.Append("[").Append(offSymbol).Append("]").ToString();
            var spacesSb = new StringBuilder();
            for (int i = 0; i < spacing; i++)
            {
                spacesSb.Append(" ");
            }
            configSpaces = spacesSb.ToString();
            var countSapceNoSb = new StringBuilder();
            var countSpaceNo = int.Parse(config[2]) + 2;
            for (int i = 0; i < countSpaceNo; i++)
            {
                countSapceNoSb.Append(" ");
            }
            configSpaceNo = countSapceNoSb.ToString();
        }
    }
}
