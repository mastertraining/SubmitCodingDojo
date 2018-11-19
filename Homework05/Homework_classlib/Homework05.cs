using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_classlib
{
    public class Homework05 : IHomework05
    {
        public List<string> listLED { get; set; }
        public List<string> listNoLED { get; set; }
        public string DisplayLEDOnScreen(string ledNo)
        {
            ledNo = ledNo.ToUpper();
    
            for (int i = 0; i < listNoLED.Count; i++)
            {
                if (ledNo == listNoLED[i])
                {
                    if (listLED[i] == "[ ]")
                    {
                        listLED[i] = "[!]";
                    }
                    else if(listLED[i] == "[!]")
                    {
                        listLED[i] = "[ ]";
                    }
                }
            }

            var newString = new StringBuilder();
            var joinLED = String.Join(" ", listLED);
            var joinNoLED = String.Join("   ", listNoLED);
            newString.AppendLine(joinLED).Append(" ").Append(joinNoLED);

            return newString.ToString();
        }
    }
}
