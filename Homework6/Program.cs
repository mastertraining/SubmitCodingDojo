using System;
using System.IO;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using YamlDotNet.Serialization;
using System.Collections.Generic;
using YamlDotNet.RepresentationModel;

namespace Homework6
{
    class Configs
    {
        public string On { get; set; }
        public string Off { get; set; }
        public int Spacing { get; set; }

        public Configs(string on, string off, int spacing)
        {
            this.On = on;
            this.Off = off;
            this.Spacing = spacing;
        }
    }

    public class LoadState
    {
        public bool[] memState { get; set; }
    }

    class Program: IHomework06
    {
        public string filePath { get; set; }
        private string fileYamlPath { get; set; }
        private Dictionary<string, string> _onOff { get; set; }
        private int _spacing { get; set; }
        private Configs _configs { get; set; }
        private bool[] _memState { get; set; }


        static void Main()
        {
            Program prm = new Program();

             for (int i = 0; true; i++)
             {
                if (i == 0)
                {
                    Console.WriteLine(prm.DisplayLEDOnScreen());
                }

                Console.Write("Please choose LED to truen On/Off: ");
                var input = Console.ReadLine();

                if (input == "save")
                {
                    prm.SaveCurrentState();
                    Console.WriteLine("Current state had been saved!");
                }
                else
                {
                    prm.DisplayLEDOnScreen(input);
                }

                Console.WriteLine(prm.DisplayLEDOnScreen());
            }
        }

        public Program(string on = "!", string off = " ", int spacing = 1)
        {
            _configs = new Configs(on, off, spacing);
            ReadYaml();
            SetAppConfigurations(_configs.On, _configs.Off, _configs.Spacing);
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            var on  = new StringBuilder("[").Append(onSymbol).Append("]").ToString();
            var off = new StringBuilder("[").Append(offSymbol).Append("]").ToString();

            _memState = LoadState();
            _spacing  = spacing;
            _onOff    = new Dictionary<string, string>{{"on", on}, {"off", off}};
        }

        public string DisplayLEDOnScreen(string ledNo = "")
        {
            if (ledNo != "")
            {
                int idx = (ledNo.ToUpper() == "A")? 9 : int.Parse(ledNo) - 1;
                _memState[idx] = (_memState[idx] == false)? true:false;
            }

            StringBuilder sbLEDs = new StringBuilder();
            StringBuilder sbIdxLEDs = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                if (_memState[i - 1] == true)
                {
                    sbLEDs.Append(_onOff["on"]).Append(' ', _spacing);
                }
                else
                {
                    sbLEDs.Append(_onOff["off"]).Append(' ', _spacing);
                }

                if (i == 10)
                {
                    sbIdxLEDs.Append(" ").Append("A").Append(' ', _spacing + 1);
                }
                else
                {
                    sbIdxLEDs.Append(" ").Append(i.ToString()).Append(' ', _spacing + 1);
                }
            }

            return new StringBuilder().AppendLine(sbLEDs.ToString())
                                        .Append(sbIdxLEDs.ToString()).ToString();
        }

        public void ReadYaml() 
        {
            filePath = @"config.yaml";
            using (StreamReader reader = new StreamReader(filePath))
            {
            var deserializer = new DeserializerBuilder().Build();
            var yamlObject = deserializer.Deserialize(reader);

            var serializer = new SerializerBuilder()
                            .JsonCompatible().Build();

            var json = serializer.Serialize(yamlObject);

            _configs = JsonConvert.DeserializeObject<Configs>(json);
            }
        }

        public bool[] LoadState()
        {
            LoadState load;
            filePath = @"memState.json";
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string json = reader.ReadToEnd();
                    load = JsonConvert.DeserializeObject<LoadState>(json);
                }
            }
            else
            {
                return new bool[10];
            }

            return load.memState;
        }

        public void SaveCurrentState()
        {
            filePath = @"memState.json";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("{\"memState\":");
                string json = JsonConvert.SerializeObject(_memState);
                sb.Append(json).Append("}");

                writer.Write(sb.ToString());
            }
        }
    }
}