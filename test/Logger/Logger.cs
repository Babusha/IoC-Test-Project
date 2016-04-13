using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Logger : ILogger
    {
        public IInputOutput InputOutput { get; set; }

        public Logger(IInputOutput inputOutput)
        {
            InputOutput = inputOutput;
        }
        public void Warning(string message)
        {
            InputOutput.Output($"[Warning] {DateTime.Now} " + message);
        }

        public void Error(string message)
        {
            InputOutput.Output($"[Error] {DateTime.Now} " + message);
        }

        public void Success(string message)
        {
            InputOutput.Output($"[Success] {DateTime.Now} " + message);
        }
    }
}
