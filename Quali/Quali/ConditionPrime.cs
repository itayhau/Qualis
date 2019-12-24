using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quali
{
    class ConditionPrime : ICondition
    {
        public bool Check(int number, out string passText)
        {
            if (number > 1)
            {
                if (number == 2)
                {
                    passText = " FOO ";
                    return true;
                }
                else
                {
                    int divider = 2;
                    int theSqrt = (int)Math.Sqrt(number);
                    while (divider <= theSqrt && number % divider != 0 && number != 2)
                    {
                        divider++;
                    }
                    if (divider > theSqrt)
                    {
                        passText = " FOO ";
                        return true;
                    }
                }
            }
            passText = "";
            return false;
        }
    }
}
