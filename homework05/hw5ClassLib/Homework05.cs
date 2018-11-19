using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace hw5ClassLib
{
    public class Homework05 : IHomework05
    {
        public List<string> listLED { get; set; }
        public List<string> listNoLED { get; set; }
        public string DisplayLEDOnScreen(string ledNo)
        {
            ledNo = ledNo.ToUpper();
            var sb = new StringBuilder();

            for (int j = 0; j < listNoLED.Count; j++)
            {

                if (ledNo == listNoLED[j])
                {

                    if (listLED[j] == "[ ]")
                    {
                        listLED[j] = "[!]";
                    }
                    else
                    {
                        listLED[j] = "[ ]";
                    }
                }
            }

            var resultLED = String.Join(" ", listLED);
            var resultNoLED = String.Join("   ", listNoLED);
            sb.AppendLine(resultLED).Append(" ").Append(resultNoLED);

            return sb.ToString();
        }
    }
}
