using System;
using System.Collections.Generic;
using System.Text;

namespace Homework14.Lib
{
    public class RunningGame
    {
        public int GoalDistance { get; set; }
        public int TriggerCombo { get; set; }
        public IEnumerable<Player> Players { get; set; }
    }
}
