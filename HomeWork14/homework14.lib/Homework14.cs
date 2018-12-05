using System;
using System.Text;

namespace homework14.lib
{
    public class Homework14 : IHomework14
    {
        private int player1_distance;
        private int player1_distanceStack;
        private int player1_distanceStackCount;
        private int player2_distance;
        private int player2_distanceStack;
        private int player2_distanceStackCount;

        private string RenderDistance
        {
            get
            {
                var display = new StringBuilder();
                display.AppendLine($"Koo ({player1_distance.ToString("00")}): {new string('*', player1_distance)}");
                display.Append($"Kee ({player2_distance.ToString("00")}): {new string('*', player2_distance)}");
                if (player1_distance == 0) display.Append($"{Environment.NewLine}The Winner is MR.Koo");
                if (player2_distance == 0) display.Append($"{Environment.NewLine}The Winner is MR.Kee");
                return display.ToString();
            }
        }

        public Homework14()
        {
            SetupANewGame();
        }

        public string GetGameResult(int number)
        {
            if (number % 2 == 0)
            {
                player1_distance -= 1 + player2_distanceStackCount;
                player1_distanceStack++;
                player2_distanceStack = 0;
            }
            else
            {
                player2_distance -= 1 + player1_distanceStackCount;
                player1_distanceStack = 0;
                player2_distanceStack++;
            }

            if (player2_distanceStack == 3)
            {
                player2_distanceStackCount++;
                player2_distanceStack = 0;
            }
            if (player1_distanceStack == 3)
            {
                player1_distanceStackCount++;
                player1_distanceStack = 0;
            }
            return RenderDistance;
        }

        public void SetupANewGame()
        {
            const int DefaultDistance = 20;
            player1_distance = DefaultDistance;
            player2_distance = DefaultDistance;
            player1_distanceStack = 0;
            player1_distanceStackCount = 0;
            player2_distanceStack = 0;
            player2_distanceStackCount = 0;
        }
    }
}
