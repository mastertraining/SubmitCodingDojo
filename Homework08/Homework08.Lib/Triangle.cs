using System;
using System.Text;

namespace Homework08.Lib {
    public class Triangle : IHomework08

    {
        public string GetTriangleShapeAsText (int input) {
            var newString = new StringBuilder ();
            for (int i = 0; i < input; i++) {
                if (i == 0) {
                    newString.Append (new string (' ', (input - 1))).Append ("/").Append ("|").AppendLine ();
                } else if (i == (input - 1)) {
                    newString.Append ("/").Append (new string ('_', input-1)).Append ("|");
                } else {
                    newString.Append (new string (' ', (input - i - 1))).Append ("/").Append (new string (' ', i)).Append ("|").AppendLine ();
                }
            }
            return newString.ToString ();
        }
    }
}