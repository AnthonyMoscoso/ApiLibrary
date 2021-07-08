using Core.Logger.Abstracts;
using Serilog;
using System;
using System.Collections.Generic;
using Utilities.Enums;

namespace Logger.Repository.Specifics
{
    public class DbSerilogService : ILogService
    {
        public string _connectionString;
        public ILogger _logger;
        public DbSerilogService(string connectionString)
        {
            _connectionString = connectionString;
            ILogger logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.MSSqlServer(connectionString)
                .CreateLogger();
            _logger = logger;
            
        }

        public IEnumerable<string> Read()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Read(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Read(MessageCode messageCode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Read(MessageCode messageCode, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public void Write(string message, MessageCode messageCode = MessageCode.information)
        {
            throw new NotImplementedException();
        }
    }
}
