using System;
using System.Text;
using HomeworkclassLib;

namespace Homework14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number: ");
            var input = int.Parse(Console.ReadLine());
            // var sn = new Logic();
            // var result = sn.GetGameResult(input);
            // Console.WriteLine(result);
            int _speedkoo = 1;
            int _speedkee = 1;
            int _numdistancekoo = 20;
            int _numdistancekee = 20;
            int _countkoo = 0;
            int _countkee = 0;

            if (input % 2 == 0)
            {
                _countkee++;
                _speedkoo += _countkoo / 3;
                _numdistancekoo -= _speedkoo;
                _countkoo = 0;

            }
            else
            {
                _countkoo++;
                _speedkee += _countkee / 3;
                _numdistancekee -= _speedkee;
                _countkee = 0;
            }

            var sb = new StringBuilder();
            // addStr.Append(new string(' ', input - i)).Append("/").Append("|").AppendLine();
            sb.Append("Koo ").Append($"({_numdistancekoo}):").AppendLine()
              .Append("Kee ").Append($"({_numdistancekee}):");
            //return sb;

            Console.WriteLine(sb);
            





        }
    }
}
