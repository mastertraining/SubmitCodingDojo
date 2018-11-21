using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using YamlDotNet.Core;
using YamlDotNet.Serialization;

namespace Homework06.Lib {
    public class LightingControl : IHomework06 {
        class ConfigLightLED {
            public string onsymbol { get; set; }
            public string offsymbol { get; set; }
            public string spaces { get; set; }
        }
        public int spacingConvertInt { get; set; }
        public string[] light = new string[] { };
        public string numberLight { get; set; }
        public string yamlFile { get; set; }
        public string onSymbol { get; set; }
        public string offSymbol { get; set; }
        public StringBuilder setLED { get; set; }
        public StringBuilder displayLED { get; set; }
        public string newLight { get; set; }
        public string filePath = @"config.yaml";
        public string DisplayLEDOnScreen (string ledNo) {
            if (ledNo == "A") {
                ledNo = "10";
            }
            var getYamlFile = LoadState ();
            var newYamlFile = getYamlFile.Split (new string[] { Environment.NewLine, "onsymbol: ", "offsymbol: ", "spaces: " }, StringSplitOptions.RemoveEmptyEntries);
            onSymbol = newYamlFile[0];
            offSymbol = newYamlFile[1];
            var spacing = string.Join ("", newYamlFile[2].Split (','));
            spacingConvertInt = int.Parse (spacing);

            SetAppConfigurations (onSymbol, offSymbol, spacingConvertInt);
            newLight = CollectAllLED ();
            setLED = new StringBuilder ();
            displayLED = DisplayLightLED (newLight, setLED);

            for (int i = 0; i <= light.Length; i++) {
                if (ledNo == i.ToString ()) {
                    light[i - 1] = (light[i - 1] == $"[{offSymbol}]") ? $"[{onSymbol}]" : $"[{offSymbol}]";
                    newLight = CollectAllLED ();
                    displayLED.Clear ();
                    displayLED = DisplayLightLED (newLight, setLED);
                }
            }
            return displayLED.ToString ();
        }
        private StringBuilder DisplayLightLED (string newLight, StringBuilder setLED) {
            return setLED.Append (newLight).AppendLine ().Append (" ").Append (numberLight);
        }
        private string CollectAllLED () {
            return string.Join (" ", light.Select (x => x));
        }
        public void SetLED () {
            light = new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            numberLight = "1   2   3   4   5   6   7   8   9   A";
        }
        public string LoadState () {
            var read = new StreamReader (filePath);
            var deserializer = new DeserializerBuilder ().Build ();
            var yamlObject = deserializer.Deserialize (read);
            read.Dispose ();
            var buildToJson = new SerializerBuilder ()
                .JsonCompatible ()
                .Build ();
            var json = buildToJson.Serialize (yamlObject);
            var reviseJson = json.Replace ("-", "");
            var jsonToObj = JsonConvert.DeserializeObject<ConfigLightLED> (reviseJson);
            var serializer = new YamlDotNet.Serialization.Serializer ();

            using (var writer = new StringWriter ()) {
                serializer.Serialize (writer, jsonToObj);
                yamlFile = writer.ToString ();
            }
            return yamlFile;
        }
        public void SaveCurrentState () {
            var positionLED = new List<int> ();
            var listLine = new List<string> ();
            for (int i = 0; i < light.Length; i++) {
                if (light[i] == $"[{onSymbol}]") {
                    positionLED.Add (i + 1);
                }
            }
            var newText = string.Join (",", positionLED);
            System.Console.WriteLine (newText);

            try {
                var textState = new StringBuilder ();
                textState.AppendLine ($"on-symbol : {onSymbol}")
                    .AppendLine ($"off-symbol : {offSymbol}")
                    .AppendLine ($"spaces : {newText}");
                using (var fs = File.Create (filePath)) {
                    Byte[] info = new UTF8Encoding (true).GetBytes (textState.ToString ());
                    fs.Write (info, 0, info.Length);
                }
                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText (filePath)) {
                    string s = "";
                    while ((s = sr.ReadLine ()) != null) {
                        Console.WriteLine (s);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine (ex.ToString ());
            }
        }
        public void SetAppConfigurations (string onSymbol, string offSymbol, int spacing) {
            if (onSymbol == "null") {
                onSymbol = onSymbol.Replace ("null", "!");
            }
            if (offSymbol == "null") {
                offSymbol = offSymbol.Replace ("null", " ");
            }
        }
        public void FirstLoad (string onSymbol, string offSymbol, int spacing) {
            var spacingCovertToStr = spacing.ToString ();

            var collectSpacing = new string[spacingCovertToStr.Length];
            for (int i = 0; i < spacingCovertToStr.Length; i++) {
                collectSpacing[i] = spacingCovertToStr.Substring (i, 1);
                System.Console.WriteLine (collectSpacing[i]);
            }
            for (int i = 0; i < light.Length; i++) {
                if (light[i] == "[ ]") {
                    light[i] = light[i].Replace ("[ ]", $"[{offSymbol}]");
                }
            }
            for (int i = 0; i < collectSpacing.Length; i++) {
                System.Console.WriteLine (collectSpacing[i]);
                for (int j = 0; j < light.Length; j++) {
                    if (j == int.Parse (collectSpacing[i]) - 1) {
                        light[j] = light[j].Replace ($"[{offSymbol}]", $"[{onSymbol}]");
                    }
                }
            }
        }
    }
}