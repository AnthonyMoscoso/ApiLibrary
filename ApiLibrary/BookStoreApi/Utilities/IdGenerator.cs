using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Utilities
{
    public class IdGenerator
    {
        public static string GetNewId()
        {
            Guid g = Guid.NewGuid();
            return g.ToString();
        }
    }
}