using System;
using System.Text;

namespace HomeworkclassLib
{
    public class Logic : IHomework14
    {
        private int _speedkoo;
        private int _speedkee;
        private int _numdistancekoo;
        private int _numdistancekee;
        private int _countkoo;
        private int _countkee;
        private int _winner;

        private string startGame;

        public string StartGame
        {
            get
            {
                var displayKoo = new string('*', 20);
                var displayKee = new string('*', 20);

                var sb = new StringBuilder();
                sb.Append("Koo ").Append($"({_numdistancekoo}): {displayKoo}").AppendLine()
                  .Append("Kee ").Append($"({_numdistancekee}): {displayKee}");
                return sb.ToString();
            }
        }

        public string GetGameResult(int number)
        {
            if (number % 2 == 0)
            {
                _countkee++;
                _speedkoo += _countkoo / 3;
                _numdistancekoo -= _speedkoo;
                _countkoo = 0;
            }
            else
            {
                _countkoo++;
                _speedkee += _countkee / 3;
                _numdistancekee -= _speedkee;
                _countkee = 0;
            }

            var displayKoo = new string('*', _numdistancekoo);
            var displayKee = new string('*', _numdistancekee);

            var sb = new StringBuilder();
            sb.Append("Koo ").Append($"({_numdistancekoo}): {displayKoo}").AppendLine()
              .Append("Kee ").Append($"({_numdistancekee}): {displayKee}");

            // ใครแพ้ใครชนะ
            //var KooIsWinner = _numdistancekoo == _winner ? sb.Append("The Winner is MR.Kee"):sb.Append("The Winner is MR.Kee");
            return sb.ToString();
        }
        public void SetupANewGame()
        {
            int ResetDistance = 20;
            _numdistancekoo = ResetDistance;
            _numdistancekee = ResetDistance;

            int speed = 1;
            _speedkoo = speed;
            _speedkee = speed;
        }
    }
}
