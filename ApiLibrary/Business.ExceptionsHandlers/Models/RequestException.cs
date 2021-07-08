using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ExceptionsHandlers.Models
{
    public class RequestException : Exception
    {
        public RequestException(string message,Exception exception) : base (message,exception)
        {

        }
    }
}
