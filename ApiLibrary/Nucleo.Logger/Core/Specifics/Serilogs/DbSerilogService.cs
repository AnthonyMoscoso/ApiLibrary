using Core.Logger.Abstracts;
using Core.Logger.Models;
using Core.Utilities.Enums;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Logger.Repository.Specifics
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
            throw new NotImplementedException();
        }



        public void Write(string message, MessageCode messageCode = MessageCode.information)
        {
            throw new NotImplementedException();
        }
    }
}
