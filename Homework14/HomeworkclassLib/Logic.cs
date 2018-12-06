using System;
using System.Text;

namespace HomeworkclassLib
{
    public class Logic : IHomework14
    {
        private int _speedkoo = 1;
        private int _speedkee = 1;
        private int _numdistancekoo = 20;
        private int _numdistancekee = 20;
        private int _countkoo = 0;
        private int _countkee = 0;

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
            return sb.ToString();
        }
        public void SetupANewGame()
        {
            throw new NotImplementedException();
        }
    }
}
