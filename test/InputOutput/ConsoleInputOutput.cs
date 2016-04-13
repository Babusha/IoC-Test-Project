using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class ConsoleInputOutput : IInputOutput
    {
        public string Input()
        {
            return Console.ReadLine();
        }

        public void Output(string message)
        {
            Console.WriteLine(message);
        }
    }
}
