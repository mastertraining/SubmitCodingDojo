using System.Text;

namespace Homework11
{
    public class Homework11 : IHomework11
    {
        public string[] numberSet { get; set; }
        public string[] rankSet { get; set; }

        public Homework11()
        {
            numberSet = new string[] { "", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "ศูนย์" };
            rankSet = new string[] { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };
        }

        public string GetReadWordOfNumber(int number)
        {
            var numberText = number.ToString();
            var rankCount = numberText.Length;

            if (rankCount == 1 && number == 0)
            {
                return "ศูนย์";
            }

            var index = 0;
            var numberWord = new StringBuilder();
            for (int i = numberText.Length; i > 0; i--)
            {
                rankCount--;
                int.TryParse(numberText[index].ToString(), out var outNumber);
                var rankText = outNumber > 0 ? rankSet[rankCount] : "";
                if (i == 2)
                {
                    var specialNumber = string.Empty;
                    if (outNumber == 2)
                    {
                        specialNumber = "ยี่";
                    }
                    else if (outNumber == 1)
                    {
                        specialNumber = "";
                    }
                    else
                    {
                        specialNumber = numberSet[outNumber];
                    }
                    numberWord.Append(specialNumber);
                }
                else if (i == 1)
                {
                    if (outNumber == 1 && numberText.Length > 1)
                    {
                        rankText = "เอ็ด";
                    }
                    else
                    {
                        rankText = numberSet[outNumber];
                    }
                }
                else
                {
                    numberWord.Append(numberSet[outNumber]);
                }
                numberWord.Append(rankText);
                index++;
            }
            return numberWord.ToString();
        }
    }
}

