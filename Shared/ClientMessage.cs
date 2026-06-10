using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ClientMessage
    {
        public required string Text { get; set; }
        public required int SenderId { get; set; }
        public required string SenderName { get; set; }
        public required DateTime DateTime { get; set; }

        public ClientMessage()
        {

        }

        [SetsRequiredMembers]
        public ClientMessage(string text, int senderId, string senderName, DateTime dateTime)
        {
            this.Text = text;
            this.SenderId = senderId;
            this.SenderName = senderName;
            this.DateTime = dateTime;
        }
    }
}
