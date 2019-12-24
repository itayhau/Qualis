using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quali
{
    class Program
    {
        static void Main(string[] args)
        {

            IWriter writer = new MyMenu().PrintMenuAndGetUserSelectionWriter(new[] { "Output to console", "Send to email" },
                new ConsoleWriter(), new EmailWriter());
            Console.WriteLine();
            Console.WriteLine();
            new FizzBuzzGamer().PlayFizzBuzz(writer, new ICondition[] { new Condition3(), new Condition5() },
                new ICondition[] { new ConditionEnds4(), new ConditionPrime() }, number => number % 2 == 1 ? 1 : 2);
        }
    }
}
