
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Enums;

namespace Core.Logger.Abstracts
{
    public interface ILogService
    {
        void Write(string message,MessageCode messageCode = MessageCode.information);

    }
}
