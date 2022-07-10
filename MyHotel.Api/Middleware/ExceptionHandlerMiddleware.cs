using Microsoft.AspNetCore.Http;
using MyHotel.Business.Exceptions;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace MyHotel.Api.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleException(httpContext, ex);
            }
        }

        private Task HandleException(HttpContext context, Exception ex)
        {
            HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError;

            context.Response.ContentType = "application/json";
            var result = string.Empty;

            switch (ex)
            {
                case NotAvailableException notFoundException:
                    httpStatusCode = HttpStatusCode.OK;
                    result = notFoundException.Message;
                    break;
                default:
                    httpStatusCode = HttpStatusCode.BadRequest;
                    result = ex.Message;
                    break;
            }
            if (result != string.Empty)
            {
                result = JsonConvert.SerializeObject(new { error = ex.Message });
            }

            context.Response.StatusCode = (int)httpStatusCode;
            return context.Response.WriteAsync(result);

        }
    }
}
