using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Message
    {
        public required string Text { get; set; }
        public required User Sender { get; set; }
        public required DateTime DateTime { get; set; }

        [SetsRequiredMembers]
        public Message(string text, User sender, DateTime dateTime)
        {
            this.Text = text;
            this.Sender = sender;
            this.DateTime = dateTime;
        }
    }
}
