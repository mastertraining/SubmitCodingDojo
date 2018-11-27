using System;
using System.IO;

namespace Homework.ConsoleApp
{
    public static class FileReader
    {
        public static string ReadTextFromDataFile(string fullPathToFile) {
            using (var fi = File.OpenText(fullPathToFile))
            {
                return fi.ReadToEnd();
            }
        }

        public static void WriteTextToDataFile(string fullPathToFile, string text) {
            File.WriteAllText(fullPathToFile, text);
        }
    }
}
