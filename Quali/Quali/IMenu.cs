using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quali
{
    public interface IMenu
    {
        IWriter PrintMenuAndGetUserSelectionWriter(string[] optionsText, params IWriter[] writers);
    }
}
