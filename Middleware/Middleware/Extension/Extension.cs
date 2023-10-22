using Microsoft.AspNetCore.Builder;
using Midddleware.MiddleBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midddleware.Extension
{
     static public class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<HelloMiddleware>();
        }
    }
}
