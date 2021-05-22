using System;

namespace BookStoreApi.Utilities.Enums
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