

using Nucleo.Utilities.Enums;

namespace Nucleo.Utilities { 
    public class MessageControl
    {
    
        public MessageCode Code { get; set; }
        public MessageType Type { get; set; }
        public bool Error { get; set; }
        public string Note { get; set; }

    }
}