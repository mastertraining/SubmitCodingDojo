using System;
using System.Linq;
using System.Text;

namespace Homework05.Lib {
    public class LightingControl : IHomework05 {
        public string[] light = new string[] { };
        public string numberLight;
        public string DisplayLEDOnScreen (string ledNo) {
            string newLight = CollectAllLED ();
            var setLED = new StringBuilder ();
            StringBuilder displayLED = DisplayLightLED (newLight, setLED);
            if (ledNo == "A") {
                ledNo = "10";
            }
            for (int i = 0; i <= light.Length; i++) {
                if (ledNo == i.ToString ()) {
                    light[i - 1] = (light[i - 1] == "[ ]") ? "[!]" : "[ ]";
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
    }
}