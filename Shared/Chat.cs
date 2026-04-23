using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Chat
    {
        private static int lastId = 0;
        public int Id { get; set; }
        public User[] Users { get; set; }
        public List<Message> Messages { get; set; }

        public Chat(User first, User second) {
            this.Users = new User[] { first, second };
            this.Messages = new List<Message>();
            this.Id = lastId++;
        }
    }
}
