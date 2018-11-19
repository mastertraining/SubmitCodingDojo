using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Homework05.classlib
{
    public class LED : IHomework05
    {
        public List<string> listLight { get; set; }
        public List<string> listLightNumbers { get; set; }
        public void defaultLight()
        {
            listLight = new List<string>(new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" });
            listLightNumbers = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
        }
        public string DisplayLEDOnScreen(string ledNo)
        {
            var lightLED = new StringBuilder();
            for (int i = 0; i < listLightNumbers.Count; i++)
            {
                if (ledNo.ToUpper() == listLightNumbers[i])
                {
                    if (listLight[i] == "[ ]")
                    {
                        listLight[i] = "[!]";
                    }
                    else
                    {
                        listLight[i] = "[ ]";
                    }
                }

            }

            var light = String.Join(" ", listLight);
            var lightNumbers = String.Join("   ", listLightNumbers);

            lightLED.AppendLine(light).Append(" ").Append(lightNumbers);
            return lightLED.ToString();

        }
    }
}
