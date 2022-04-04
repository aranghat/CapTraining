using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WebApiBasics.CustomMiddleWare
{
    public class LogRequestMiddleWare
    {
        public RequestDelegate _next;

        public LogRequestMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            
            File.AppendAllText(@"D:\CapTraining\Log\webrequestlog.txt", $"Recieved request for {context.Request.Path} @ {DateTime.Now}");

            await _next(context);
        }
    }
}
