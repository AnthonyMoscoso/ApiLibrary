using System;

namespace Core.Utilities.Enums
{
    public enum MessageCode
    {
        information,error,exception
    }
    public class MessageCodeNames
    {
        public static string information = Enum.GetName(typeof(MessageCode), MessageCode.information);
        public static string error = Enum.GetName(typeof(MessageCode), MessageCode.error);
        public static string exception = Enum.GetName(typeof(MessageCode), MessageCode.exception);
    }
}