using System;
using System.Text;

namespace ProgramHomework08
{
    class Program
    {
        static void Main(string[] args)
        {
            //1     /|
            //2    / |
            //3   /__|
            var addStr = new StringBuilder();
            System.Console.WriteLine("Enter your number");
            var input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (i == 1)
                {
                    addStr.Append(new string('x', input - i)).Append("/").Append("|").AppendLine();
                }
                else if (i == input)
                {
                    addStr.Append("/").Append(new string('_', input)).Append("|");
                }
                else
                {
                    addStr.Append(new string(' ',(input-i))).Append("/").Append(new string(' ',i)).Append("|").AppendLine();
                }

            }
            Console.Write(addStr);
           
        }
    }
}
