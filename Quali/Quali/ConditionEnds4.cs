using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quali
{
    class ConditionEnds4 : ICondition
    {
        public bool Check(int number, out string passText)
        {
            if (number % 10 == 4)
            {
                passText = " BAR ";
                return true;
            }
            passText = "";
            return false;
        }
    }
}
