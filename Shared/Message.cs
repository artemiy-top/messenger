using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Message
    {
        public string Text { get; set; }
        public User Sender { get; set; }
        public DateTime DateTime { get; set; }

        public Message(string text, User sender, DateTime dateTime)
        {
            this.Text = text;
            this.Sender = sender;
            this.DateTime = dateTime;
        }
    }
}
