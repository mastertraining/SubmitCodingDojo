using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Homework14.Lib
{
    public class Homework14 : IHomework14
    {
        private const int GOAL_DISTANCE = 20;
        private const int MAX_COMBO = 3;
        private const string KOO_NAME = "Koo";
        private const string KEE_NAME = "Kee";
        private IEnumerable<Player> Players;
        private string winnerName;

        public Homework14()
        {
            SetupANewGame();
        }

        private void AddPlayerByName(string playerName)
        {
            var player = new Player { Name = playerName };
            Players = Players.Concat(new List<Player> { player });
        }

        private void PlayerRun(string playerName)
        {
            var runPlayer = Players.FirstOrDefault(it => it.Name == playerName);
            runPlayer.Distance += runPlayer.Speed;
            runPlayer.Combo++;

            var hasTrigCombo = runPlayer.Combo % 3 == 0;
            var otherplayer = Players.Where(it => it.Name != playerName);

            foreach (var player in otherplayer)
            {
                player.Combo = 0;
                if (hasTrigCombo)
                {
                    player.Speed++;
                }
            }
        }

        public string GetResultString()
        {
            var result = new StringBuilder();

            foreach (var player in Players)
            {
                result.AppendFormat("{0,-7}", player.Name);
                var distanceToGoal = GOAL_DISTANCE - player.Distance < 0 ? 0 : GOAL_DISTANCE - player.Distance;
                result.AppendFormat("({0}): {1}", distanceToGoal.ToString("00"), new string('*', distanceToGoal));
                result.AppendLine();
                if (player.Distance >= GOAL_DISTANCE) winnerName = player.Name;
            }

            if (!string.IsNullOrEmpty(winnerName))
            {
                result.AppendFormat("The Winner is Mr.{0}", winnerName);
                result.AppendLine();
                result.Append("Do you want to try again?: ");
            }
            else
            {
                result.Append("Please input a number: ");
            }

            return result.ToString();
        }

        public void SetupANewGame()
        {
            winnerName = string.Empty;
            Players = new List<Player>();
            AddPlayerByName(KOO_NAME);
            AddPlayerByName(KEE_NAME);
        }

        public string GetGameResult(int number)
        {
            var isEven = number % 2 == 0;
            var playerName = string.Empty;

            if (isEven) playerName = KOO_NAME;
            else playerName = KEE_NAME;

            PlayerRun(playerName);

            return GetResultString();
        }

        public string PlayAGame(string input)
        {
            var gameIsOver = !string.IsNullOrEmpty(winnerName);
            if (gameIsOver)
            {
                if (input == "yes")
                {
                    SetupANewGame();
                    return GetResultString();
                }
                return GetResultString();
            }
            else
            {
                return GetGameResult(int.Parse(input));
            }
        }
    }
}
