﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class FileConsoleInputOutput : IInputOutput
    {
        public string Input()
        {
            throw new NotImplementedException();
        }

        public void Output(string message)
        {
            
            using (StreamWriter outputFile = new StreamWriter("logfile.txt", true))
            {
                outputFile.WriteLine(message);
            }      
           Console.WriteLine(message);
        }
    }
}
