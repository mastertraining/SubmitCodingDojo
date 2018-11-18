using System;
using Homework05.classlib;
using System.Collections.Generic;

namespace Homework05.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, List<string>> dic = new Dictionary<string, List<string>>();

            List<string> li1 = new List<string>();
            li1.Add("[ ]");
            li1.Add("[ ]");
            li1.Add("[ ]");
            li1.Add("[ ]");
            li1.Add("[ ]");
            li1.Add("[ ]");
            li1.Add("[ ]");
            li1.Add("[ ]");
            li1.Add("[ ]");
            li1.Add("[ ]");

            List<string> li2 = new List<string>();
            li2.Add(" ");
            li2.Add(" 1 ");
            li2.Add(" 2 ");
            li2.Add(" 3 ");
            li2.Add(" 4 ");
            li2.Add(" 5 ");
            li2.Add(" 6 ");
            li2.Add(" 7 ");
            li2.Add(" 8 ");
            li2.Add(" 9 ");
            li2.Add(" A ");

            dic["1"] = li1;
            dic["2"] = li2;


            foreach (string key in dic.Keys)
            {
                foreach (string val in dic[key])
                {
                    Console.Write(val);
                    if (val == " ")
                    {
                        System.Console.WriteLine("");
                    }
                    if (true)
                    {
                    
                    }
                }
            }
        }
    }
}
