using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomRouteHandler.Handlers
{
    public class exampleHandler
    {
        public RequestDelegate Handler()
        {


            return async c =>
            {
                c.Response.WriteAsync("Hello World");
            };
        }
    }
}
