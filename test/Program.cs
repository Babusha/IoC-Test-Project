using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder
                .RegisterType<ConsoleInputOutput>()
                //.Register(c => new EMailInputOutput("test@mfsa.ru"))
                .As<IInputOutput>();

            builder
                .RegisterType<LoggerColored>()
                .As<ILogger>();

            IContainer container = builder.Build();

            var logger = container.Resolve<ILogger>(); 

            logger.Success("It works!");
            logger.Warning("You can die");
            logger.Error("You have died, ooops!");  
        }
    }
}
