using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Chat
    {
        private static int lastId = 0;
        public required int Id { get; set; }
        public required User[] Users { get; set; }
        public required List<Message> Messages { get; set; }

        [SetsRequiredMembers]
        public Chat(User first, User second) {
            this.Users = new User[] { first, second };
            this.Messages = new List<Message>();
            this.Id = lastId++;
        }
    }
}
