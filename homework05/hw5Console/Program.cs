using System;
using System.Text;
using System.Threading;


namespace hw5Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var LEDs = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
            var LED = new StringBuilder();


            for (int i = 0; i < LEDs.Length; i++)
            {
                LED.Append('[');
                var compare = string.Equals(LEDs[i], );
                // if (compare)
                // {
                //     LED.Append(' ');
                // }
                // else
                // {
                //     LED.Append('!');
                // }

                switch (compare)
                {

                    case true:
                        LED.Append('!');
                        break;

                    default:
                        LED.Append(' ');
                        break;
                }

                LED.Append("]");
                // Console.Write($"[ ]{Environment.NewLine}{i} ");
            }

            LED.Append(Environment.NewLine);

            for (int i = 0; i < LEDs.Length; i++)
            {
                LED.Append(' ').Append(LEDs[i]).Append(' ');
                // Console.Write($"[ ]{Environment.NewLine}{i} ");
            }

            Console.WriteLine(LED);
            // Console.WriteLine(num);

            Console.Write($"Please choose LED to turn On/Off: {Console.Read().ToString()}");


        }
    }
}
