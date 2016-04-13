using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public interface ILogger
    {
        IInputOutput InputOutput { get; set; }
        void Warning(string message);
        void Error(string message);
        void Success(string message);
    }
}
