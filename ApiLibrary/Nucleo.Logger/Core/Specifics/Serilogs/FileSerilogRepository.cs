using Core.Logger.Abstracts;
using Core.Logger.Models;
using Core.Utilities.Enums;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Logger.Specifics
{
    public class FileSerilogRepository : ILogService
    {
        public string _connectionString;

        public ILogger _logger;

        public FileSerilogRepository(string connectionString)
        {
            _connectionString = connectionString;
            ILogger logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(connectionString,Serilog.Events.LogEventLevel.Fatal,rollingInterval : RollingInterval.Day)
                .CreateLogger();
            _logger = logger;
        }



        public IEnumerable<MessageLog> Read()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MessageLog> Read(DateTime dateTime)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<MessageLog> Read(MessageCode messageCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MessageLog> Read(MessageCode messageCode, DateTime dateTime)
        {
            if (File.Exists(_connectionString))
            {
                yield return null;              
            }
        }


        public void Write(string message, MessageCode messageCode = MessageCode.information)
        {
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
