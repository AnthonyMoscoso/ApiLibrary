using Core.Logger.Abstracts;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using Utilities.Enums;

namespace Logger.Specifics
{
    public class FileSerilogService : ILogService
    {
        public string _logFile;

        public ILogger _logger;


        public FileSerilogService(string logFileName = "")
        {
            _logFile = logFileName;
            if (string.IsNullOrEmpty(logFileName))
            {
                _logFile = @"C:\Log_Dir\log.txt";
            }
            else
            {
                _logFile = $@"C:\Log_Dir\{logFileName}.txt";
            }
        }

 
        public void Write(string message, MessageCode messageCode = MessageCode.information)
        {
          
           _logger = new LoggerConfiguration()
                .MinimumLevel.Debug() 
                .WriteTo.File(_logFile, rollingInterval: RollingInterval.Day)
                .CreateLogger();


            switch (messageCode)
            {
                case MessageCode.error:
                    _logger.Error(message);
                    break;
                case MessageCode.exception:
                    _logger.Error(message);
                    break;
                case MessageCode.information:
                    _logger.Information(message);
                    break;
                default:
                    _logger.Information(message);
                    break;

            }
        }
    }


}
