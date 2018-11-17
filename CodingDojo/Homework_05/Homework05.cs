using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_05
{
    public class Homework05 : IHomework05
    {
        private IEnumerable<string> led;
        public Homework05() {
            led = Enumerable.Repeat("[ ]", 10);
        }

        public string DisplayLEDOnScreen(string ledNo)
        {
            throw new NotImplementedException();
        }
    }
}
