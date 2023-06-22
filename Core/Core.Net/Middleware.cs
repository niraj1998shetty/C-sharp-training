﻿namespace Core.Net
{
    public class Middleware
    {
        private RequestDelegate _next;

        public Middleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method == HttpMethods.Get && context.Request.Query["custom"] == "true")
            {
                if (context.Response.HasStarted)
                {
                    context.Response.ContentType = "text/plain";
                }

                await context.Response.WriteAsync("Custom MiddleWare \n");
            }
            await _next(context);
            
        }
    }
}
