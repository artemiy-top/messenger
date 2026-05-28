using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerStorage
    {
        public static List<User> Users = new List<User>
        {
            new User("John", "12345"),
        };
        public static List<Chat> Chats = new List<Chat>();
    }
}
