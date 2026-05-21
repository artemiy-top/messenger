using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class AuthRequest
    {
        public required string Name { get; set; }
        public required string Password { get; set; }
    }

    public class RegisterRequest
    {
        public required string Name { get; set; }
        public required string Password { get; set; }
    }

    public class SendMessageRequest
    {
        public required int ChatId { get; set; }
        public required string Message { get; set; }
    }

    public class GetLastMessagesRequest
    {
        public required int ChatId { get; set; }
    }
}
