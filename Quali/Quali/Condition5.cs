using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quali
{
    class Condition5 : ICondition
    {
        public bool Check(int number, out string passText)
        {
            if (number % 5 == 0)
            {
                passText = " BuZZ \n";
                return true;
            }
            passText = "";
            return false;
        }
    }
}
