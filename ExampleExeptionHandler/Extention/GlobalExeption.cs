using System.Net;
using Microsoft.AspNetCore.Diagnostics;

namespace ExampleExeptionHandler.Extention
{
    public class GlobalExeption : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            var problem = new NewResponce
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Message = exception.Message,
                Typy = exception.GetType().Name
            };
            await httpContext.Response.WriteAsJsonAsync(problem);
            return true;
        }
    }

    public class NewResponce
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Typy { get; set; }
    }
}
