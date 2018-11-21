using System;
using System.Text;

namespace homework05console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var listLED = new string[] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
            var ledNumber = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", };

            string leds = "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]";
            string number = " 1   2   3   4   5   6   7   8   9   A";
            var add = new StringBuilder();
            var showDisplay = add.Append($"{leds}\n{number}");
            System.Console.WriteLine(showDisplay);
            Console.WriteLine("Please choose LED to turn On/Off: ");
            var ledNo = Console.ReadLine();

            var led = ledNo.ToUpper();
            var sb = new StringBuilder();
            while (true)
            {
                for (int i = 0; i < ledNumber.Length; i++)
                {
                    if (ledNo == ledNumber[i])
                    {
                        if (listLED[i] == "[ ]")
                        {
                            listLED[i] = "[!]";
                        }
                        else
                        {
                            listLED[i] = "[ ]";
                        }

                    }
                }
                var result = string.Join("   ", ledNumber);
                var resultLED = String.Join(" ", listLED);
                sb.AppendLine(resultLED).Append(" ").AppendLine(result);
                System.Console.WriteLine(sb.ToString());                
                ledNo = Console.ReadLine();
            }
        }
    }
}
