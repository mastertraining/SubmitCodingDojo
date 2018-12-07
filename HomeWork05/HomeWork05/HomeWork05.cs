using System;

namespace HomeWork05
{
    public class Homework05 : IHomework05
    {
        private string[] ledArray = new string[10] { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        private readonly string[] switchNo = new string[10] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
        private bool[] ledSwitch = new bool[10] { false, false, false, false, false, false, false, false, false, false, };

        public string DisplayLEDOnScreen(string ledNo)
        {
            SetSwitch(ledNo);
            return $"{String.Join(" ", ledArray)}{Environment.NewLine} {String.Join("   ", switchNo)}";
        }

        private void SetSwitch(string input)
        {
            switch (input.ToUpper())
            {
                case "1":
                    if (ledSwitch[0])
                    {
                        ledSwitch[0] = false;
                        ledArray[0] = "[ ]";
                    }
                    else
                    {
                        ledSwitch[0] = true;
                        ledArray[0] = "[!]";
                    }
                    break;
                case "2":
                    if (ledSwitch[1])
                    {
                        ledSwitch[1] = false;
                        ledArray[1] = "[ ]";
                    }
                    else
                    {
                        ledSwitch[1] = true;
                        ledArray[1] = "[!]";
                    }
                    break;
                case "3":
                    if (ledSwitch[2])
                    {
                        ledSwitch[2] = false;
                        ledArray[2] = "[ ]";
                    }
                    else
                    {
                        ledSwitch[2] = true;
                        ledArray[2] = "[!]";
                    }
                    break;
                case "4":
                    if (ledSwitch[3])
                    {
                        ledSwitch[3] = false;
                        ledArray[2] = "[ ]";
                    }
                    else
                    {
                        ledSwitch[3] = true;
                        ledArray[3] = "[!]";
                    }
                    break;
                case "5":
                    if (ledSwitch[4])
                    {
                        ledSwitch[4] = false;
                        ledArray[4] = "[ ]";
                    }
                    else
                    {
                        ledSwitch[4] = true;
                        ledArray[4] = "[!]";
                    }
                    break;
                case "6":
                    if (ledSwitch[5])
                    {
                        ledSwitch[5] = false;
                        ledArray[5] = "[ ]";
                    }
                    else
                    {
                        ledSwitch[5] = true;
                        ledArray[5] = "[!]";
                    }
                    break;
                case "7":
                    if (ledSwitch[6])
                    {
                        ledSwitch[6] = false;
                        ledArray[6] = "[ ]";
                    }
                    else
                    {
                        ledSwitch[6] = true;
                        ledArray[6] = "[!]";
                    }
                    break;
                case "8":
                    if (ledSwitch[7])
                    {
                        ledSwitch[7] = false;
                        ledArray[7] = "[ ]";
                    }
                    else
                    {
                        ledSwitch[7] = true;
                        ledArray[7] = "[!]";
                    }
                    break;
                case "9":
                    if (ledSwitch[8])
                    {
                        ledSwitch[8] = false;
                        ledArray[8] = "[ ]";
                    }
                    else
                    {
                        ledSwitch[8] = true;
                        ledArray[8] = "[!]";
                    }
                    break;
                case "A":
                    if (ledSwitch[9])
                    {
                        ledSwitch[9] = false;
                        ledArray[9] = "[ ]";
                    }
                    else
                    {
                        ledSwitch[9] = true;
                        ledArray[9] = "[!]";
                    }
                    break;
                case "":
                    break;
                default:
                    Console.WriteLine("Wrong input !");
                    break;
            }
        }
    }
}
