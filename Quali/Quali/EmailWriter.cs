using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quali
{
    public class EmailWriter : IWriter
    {
        public void Write(string gameResult)
        {
            Console.WriteLine($"EMAIL:\n{gameResult}");
        }
    }
}
