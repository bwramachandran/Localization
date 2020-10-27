using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Text;
using System.Threading.Tasks;

namespace LocalizationTools.Data.Logging
{
    public class LocalizationToolsExceptionMiddleware
    {
        private readonly RequestDelegate m_next;
        private ILogger m_logger;

        public LocalizationToolsExceptionMiddleware(RequestDelegate next)
        {
            m_next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await m_next(context);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine($"The following error happened: {e.Message}");
                WriteExceptionData(context, e.GetType(), e.Message);
            }
        }

        private void WriteExceptionData(HttpContext context, Type exceptionType, string exceptionMessage = "", string contentType = @"text/plain")
        {
            context.Response.Headers.Add("Exception", exceptionType.ToString());
            context.Response.ContentType = contentType;

            if (!string.IsNullOrEmpty(exceptionMessage))
            {
                m_logger.LogError("Error in the middleware", exceptionMessage);
            }
        }
    }
    public static class LocalizationToolExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseLocalizationToolsExceptionMiddleWare(this IApplicationBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            return builder.UseMiddleware<LocalizationToolsExceptionMiddleware>();
        }
    }
}
