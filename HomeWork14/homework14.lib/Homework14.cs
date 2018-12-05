using System;
using System.Text;

namespace homework14.lib
{
    public class Homework14 : IHomework14
    {
        private int player1_distance;
        private int player2_distance;

        private string RenderDistance
        {
            get
            {
                var display = new StringBuilder();
                display.AppendLine($"Koo ({player1_distance}): {new string('*', player1_distance)}");
                display.Append($"Kee ({player2_distance}): {new string('*', player2_distance)}");
                return display.ToString();
            }
        }

        public Homework14()
        {
            SetupANewGame();
        }

        public string GetGameResult(int number)
        {
            if (number % 2 == 0) player1_distance--;
            else player2_distance--;
            return RenderDistance;
        }

        public void SetupANewGame()
        {
            const int DefaultDistance = 20;
            player1_distance = DefaultDistance;
            player2_distance = DefaultDistance;
        }
    }
}
