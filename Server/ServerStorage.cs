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
            new User("John", "12345"), // [0]
            new User("Jane", "23456"), // [1]
            new User("Donald", "34567"), // [2]
        };
        public static List<Chat> Chats = new List<Chat>
        {
            new Chat(Users[0], Users[1])
            {
                Messages = new List<Message>
                {
                    new Message("Привет!", Users[0], DateTime.Now),
                },
            },
            new Chat(Users[0], Users[2])
            {
                Messages = new List<Message>
                {
                    new Message("Пока", Users[2], DateTime.Now),
                },
            },
        };
    }
}
