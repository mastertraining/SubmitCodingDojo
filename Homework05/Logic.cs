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
            var switchNo = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
            ledNo = ledNo.ToUpper();
            for (int i = 0; i < switchNo.Length; i++)
            {
                if (ledNo == switchNo [i])
                {
                    switchh.Select(it => it ? "[!]" : "[ ]");
                //    switchh[i] = !switchh[i];
                }
            }


            var collected = new bool[] { false, false, false, false, false, false, false, false, false, false };
            var selected = collected.Select(it => it ? "[!]" : "[ ]");
            var b = string.Join("  ", selected);
            var result = b.ToString();
            return "result";

            // ledNo = "false";
            //  bool b = bool.Parse(ledNo);
            // return logic();

            // var input = new bool[10];
            // var test = logic.




            // string value2 = "false";
            // if (value2 == "true")
            // {
            //     Console.WriteLine(value2);
            // }

            // int.TryParse(ledNo, out int ledNumber);
            // var isSpecialAlphabet = ledNo.Equals("a", StringComparison.CurrentCultureIgnoreCase);
            // var isNumberValid = ledNumber > 0 && ledNumber < 10;
            // if (!isNumberValid && !isSpecialAlphabet) return RenderLeds();
        }
    }
}
