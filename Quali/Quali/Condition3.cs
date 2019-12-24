using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quali
{
    public class Condition3 : ICondition
    {
        public bool Check(int number, out string passText)
        {
            if (number % 3 == 0)
            {
                passText = " FiZZ \n";
                return true;
            }
            passText = "";
            return false;
        }
    }
}
