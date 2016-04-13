using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class LoggerColored : ILogger
    {
        public IInputOutput InputOutput { get; set; }
        public LoggerColored(IInputOutput inputOutput)
        {
            InputOutput = inputOutput;
        }
        public void Warning(string message)
        {
            InputOutput.Output($"[Warning] {DateTime.Now} ".Yellow().Bold() + message);
        }

        public void Error(string message)
        {
            InputOutput.Output($"[Error] {DateTime.Now} ".Red().Bold() + message);
        }

        public void Success(string message)
        {
            InputOutput.Output($"[Success] {DateTime.Now} ".Green() + message);
        }
    }
}
