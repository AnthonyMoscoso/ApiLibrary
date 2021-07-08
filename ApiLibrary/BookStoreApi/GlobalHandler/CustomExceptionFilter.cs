using Core.Logger.Abstracts;
using Logger.Specifics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace BookStoreApi.GlobalHandler
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
         ILogService _log;

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            string exceptionMessage = actionExecutedContext.Exception.InnerException?.InnerException?.Message ?? actionExecutedContext.Exception.Message;
            _log = new FileSerilogService();
            _log.Write(exceptionMessage,Utilities.Enums.MessageCode.exception);
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError){
                
                Content = new StringContent(exceptionMessage),
                   
            };
            actionExecutedContext.Response = response;
        }
    }
}