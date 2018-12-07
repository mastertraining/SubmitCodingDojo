using System;
using System.Linq;
using System.Text;

namespace Homework05
{
    class Logic : IHomework05
    {
        public string DisplayLEDOnScreen(string ledNo)
        {
            var switchh = new bool[] { false, false, false, false, false, false, false, false, false, false };
            var switchhB = new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            var switchNo = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
            ledNo = ledNo.ToUpper();
            for (int i = 0; i < switchNo.Length; i++)
            {
                if (ledNo == switchNo [i])
                {
                     //switchh[i] = !switchh[i];
                }
            }
             return "switchh";


            // var collected = new bool[] { false, false, false, false, false, false, false, false, false, false };
            // var selected = collected.Select(it => it ? "[!]" : "[ ]");
            // var b = string.Join("  ", selected);
            // var result = b.ToString();
            // return "result";

        }
    }
}
