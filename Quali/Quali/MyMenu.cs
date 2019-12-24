using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quali
{
    public class MyMenu : IMenu
    {
        public int GetUserOptions(int min, int max)
        {
            int result = -1;
            string option = null;
            do
            {
                Console.WriteLine($"Please choose an option between {min}-{max}");
                option = Console.ReadLine();
            }
            while (!int.TryParse(option, out result) || result < min || result > max);
            return result;

        }

        public IWriter PrintMenuAndGetUserSelectionWriter(string[] optionsText, params IWriter[] writers)
        {
            if (optionsText.Length != writers.Length)
                throw new ArgumentException("Text does not match writer options");
            Console.WriteLine("Welcome to FIZZ BUZZ:");
            Console.WriteLine("Select:");
            for (int i = 0; i < optionsText.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {optionsText[i]}");
            }
            int selection = GetUserOptions(1, writers.Length);
            return writers[selection - 1];
        }

    }
}
