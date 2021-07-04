using Core.Logger.Models;
using Core.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Logger.Abstracts
{
    public interface ILogService
    {
        void Write(string message,MessageCode messageCode = MessageCode.information);
        IEnumerable<MessageLog> Read();
        IEnumerable<MessageLog> Read(DateTime dateTime);
        IEnumerable<MessageLog> Read(MessageCode messageCode);
        IEnumerable<MessageLog> Read(MessageCode messageCode,DateTime dateTime);
  
    }
}
