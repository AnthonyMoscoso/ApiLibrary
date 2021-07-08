using Core.Logger.Abstracts;
using Logger.Specifics;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace BookStoreApi.GlobalHandler
{
    public class GlobalExceptionHandler : ExceptionHandler
    {
  
        public void TaskHandle(ExceptionHandlerContext context, CancellationToken cancellationToken)
        {
            string errorMessage = context.Exception.InnerException?.InnerException?.Message ?? context.Exception.Message;

            HttpResponseMessage response = context.Request.CreateResponse(HttpStatusCode.InternalServerError,
            new
            {
                message = errorMessage
            });
            response.Headers.Add("X-ERROR", errorMessage);
            context.Result = new ResponseMessageResult(response);
        }


    }
}