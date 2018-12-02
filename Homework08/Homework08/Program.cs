using System;
using System.Text;
using Homework08.Lib;

namespace Homework08 {
    class Program {
        static void Main (string[] args) {
            var call = new Triangle();
            var input = Int32.Parse (Console.ReadLine ());
            var result = call.GetTriangleShapeAsText(input);
            System.Console.WriteLine(result);
        }
    }
}