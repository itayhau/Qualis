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

        public void PlayFizzBuzz(IWriter writer, params ICondition[] conditions)
        {
            string resultText = "";
            var cond = conditions.ToList(); ;1
            for (int i = START_FROM; i <= END_AT; i++)
            {
                if (cond.Where(c =>
                {
                    bool result = c.Check(i, out string moreText);
                    resultText += moreText;
                    return result;
                }).ToList().Count  == 0)
                    resultText += i + "\n";
            }
            writer.Write(resultText);
        }
    }
}
