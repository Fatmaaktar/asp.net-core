using DependencyInjection.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class ConsoleLog: ILog
    {
        public ConsoleLog(int a)
        {

        }
        public void Log()
        {
            Console.WriteLine("Consola loglama işlemi gerçekleştirldi..");
        }

    }
}
