using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CafeAutomationBLL.Utils
{
    public class ExceptionMiddleware
    {

        public RequestDelegate _requestDelegate;

        public ExceptionMiddleware(RequestDelegate requestDelegate)
        {
            this._requestDelegate = requestDelegate;

        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _requestDelegate(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }
        private async Task HandleException(HttpContext context, Exception ex)
        {

            /*var log = new Log()
            {
                LogDescription=ex.Message,
                LogMethod=context.Request.Method.SubstringSafe(250),
                LogPath=context.Request.Path.ToString().SubstringSafe(250),
                LogStatusCode=context.Response.StatusCode,
                MachineName = Environment.MachineName,
                CreatedDate=DateTime.Now,
            };
            TpHetrL3Context tpHetrL3Context = new TpHetrL3Context();
            await tpHetrL3Context.Logs.AddAsync(log);
            await tpHetrL3Context.SaveChangesAsync();

            var res = new ReturnResult
            {
                msg = "Seviye-3 Program Hatası",
                success = 0,
                objectValue = ex.StackTrace,
                Value=ex.Message
            };*/
            var res = new object
            {

            };
            var errorMessage = JsonSerializer.Serialize(res);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            await context.Response.WriteAsync(errorMessage);
        }



    }
}
