using DependencyInjection.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Example //services yapılanma örneği
    {
        public Example()
        {

            IServiceCollection services = new ServiceCollection(); //Built - in IoC
            services.Add(new ServiceDescriptor(typeof(ConsoleLog),new ConsoleLog(5)));
            services.Add(new ServiceDescriptor(typeof(TextLog),new TextLog()));

            ServiceProvider provider= services.BuildServiceProvider(); //Somut container/provider/sağlayıcı
            provider.GetService<ConsoleLog>();
            provider.GetService<TextLog>();
        }
        
    }
}
