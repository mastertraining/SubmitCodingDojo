using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HomeWork5.classlib;

namespace HomeWork5.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var listNoLed = new List<string>(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" });
            var listStatusLed = new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false });
            string noLed = null;
            var hw5 = new HomeWork5ClassLib();
            
            while (true)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < listNoLed.Count; j++)
                    {
                        if (i == 0)
                        {
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
                                Console.Write("[!]\t");
                            }
                            else
                            {
                                Console.Write("[ ]\t");
                            }
                        }
                        else
                        {
                            Console.Write(" " + listNoLed[j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
                Console.Write("Please choose LED to turn On/Off: ");
                noLed = Console.ReadLine().ToUpper();
            }
        }
    }
}
