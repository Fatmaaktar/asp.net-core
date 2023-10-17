using DependencyInjection.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class TextLog:ILog
    {
        public void Log()
        {
            Console.WriteLine("Text dosyasına loglama işlemi gerçekleştirildi");
        }
    }
}
