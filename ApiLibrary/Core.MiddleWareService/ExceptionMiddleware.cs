using Core.Logger.Abstracts;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace Core.MiddleWareService
{
    public class ExceptionMiddleware 
    {
        readonly ILogService _log;

        public ExceptionMiddleware()
        {
        }

        public ExceptionMiddleware(ExceptionLoggerContext context)
        {

        }

        public ExceptionMiddleware(RequestDelegate next,ILogService log)
        {
            _log = log;
        }
    }
}
