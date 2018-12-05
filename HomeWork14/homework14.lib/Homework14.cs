using System;
using System.Text;

namespace homework14.lib
{
    public class Homework14 : IHomework14
    {
        private const int WinnerDistance = 0;
        private const int ResetNumberStack = 0;

        private int player1_distance;
        private int player1_numberStack;
        private int player1_combo;
        private int player2_distance;
        private int player2_numberStack;
        private int player2_combo;

        private bool IsGameEnd => player1_distance == WinnerDistance || player2_distance == WinnerDistance;

        public string RenderDistance
        {
            get
            {
                var player1_score = player1_distance.ToString("00");
                var player1_displayDistance = new string('*', player1_distance);

                var player2_score = player2_distance.ToString("00");
                var player2_displayDistance = new string('*', player2_distance);

                var display = new StringBuilder();
                display.AppendLine($"Koo ({player1_score}): {player1_displayDistance}").
                        Append($"Kee ({player2_score}): {player2_displayDistance}");

                if (player1_distance == WinnerDistance) display.Append($"{Environment.NewLine}The Winner is MR.Koo");
                if (player2_distance == WinnerDistance) display.Append($"{Environment.NewLine}The Winner is MR.Kee");
                return display.ToString();
            }
        }

        public Homework14() => SetupANewGame();

        public string GetGameResult(int number)
        {
            var isNumberValid = number > 0;
            if (isNumberValid) CalculateDistance(number);

            return RenderDistance;
        }

        public void SetupANewGame()
        {
            const int ResetDistance = 20;
            player1_distance = ResetDistance;
            player2_distance = ResetDistance;

            player1_numberStack = ResetNumberStack;
            player2_numberStack = ResetNumberStack;

            const int ResetCombo = 1;
            player1_combo = ResetCombo;
            player2_combo = ResetCombo;
        }

        private void CalculateDistance(int number)
        {
            if (IsGameEnd) return;

            var isEvenNumber = number % 2 == 0;
            if (isEvenNumber)
            {
                player1_distance -= player2_combo;
                player1_numberStack++;
                player2_numberStack = ResetNumberStack;
            }
            else
            {
                player2_distance -= player1_combo;
                player1_numberStack = ResetNumberStack;
                player2_numberStack++;
            }

            CalculateCombo();
        }

        private void CalculateCombo()
        {
            const int MaximumStack = 3;
            if (player1_numberStack == MaximumStack)
            {
                player1_combo++;
                player1_numberStack = ResetNumberStack;
            }
            else if (player2_numberStack == MaximumStack)
            {
                player2_combo++;
                player2_numberStack = ResetNumberStack;
            }
        }
    }
}
