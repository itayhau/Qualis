using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quali
{
    public class FizzBuzzGamer : IFizzBuzzGamer
    {
        public const int START_FROM = 1;
        public const int END_AT = 100;

        public void PlayFizzBuzz(IWriter writer, ICondition[] conditionsPlayer1, ICondition[] conditionPlayer2, Func<int, int> whichPlayer)
        {
            string resultText = "";

            for (int i = START_FROM; i <= END_AT; i++)
            {

                int passedConditions = 0;
                ICondition[] conditionList = whichPlayer(i) == 1 ? conditionsPlayer1 : conditionPlayer2;
                foreach (var condition in conditionList)
                {
                    bool result = condition.Check(i, out string moreText);
                    if (result)
                    {
                        resultText += moreText;
                        passedConditions++;
                    }
                }
                if (passedConditions > 0)
                {
                    resultText += '\n';
                }
                else
                {
                    resultText += i + "\n";
                }
            }
            writer.Write(resultText);
        }
    }
}
