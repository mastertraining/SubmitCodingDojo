using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeWork5.classlib
{
    public class HomeWork5ClassLib : IHomework05
    {
        public string DisplayLEDOnScreen(string ledNo)
        {
            var listNoLed = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
            var listStatusLed = new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false });
            string noLed = ledNo.ToUpper();
            var sb = new StringBuilder();
            while (true)
            {
                // for (int i = 0; i < 2; i++)
                // {
                    for (int j = 0; j < listNoLed.Count; j++)
                    {
                        // if (i == 0)
                        // {
                            if (noLed == listNoLed[j])
                            {
                                if (listStatusLed[j] == false)
                                {
                                    listStatusLed[j] = true;
                                }
                                else
                                {
                                    listStatusLed[j] = false;
                                }
                            }

                            if (listStatusLed[j])
                            {
                                sb.Append("[!]\t");
                                // Console.Write("[!]\t");
                            }
                            else
                            {
                                sb.Append("[ ]\t");
                                // Console.Write("[ ]\t");
                            }
                        // }
                        // else
                        // {
                        //     Console.Write(" " + listNoLed[j] + "\t");
                        // }
                    }
                    // Console.WriteLine();
                // }
                // Console.Write("Please choose LED to turn On/Off: ");
                // noLed = Console.ReadLine().ToUpper();
            }
            return sb.ToString();
        }
    }
}
