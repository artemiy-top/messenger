using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerFunctions
    {
        public static User Register(string userName)
        {
            User newUser = new User(userName);
            ServerStorage.Users.Add(newUser);
            return newUser;
        }

        public static Message SendMessage(string textMessage, int senderId, int chatId)
        {
            User sender = ServerStorage.Users.Find((user) => user.Id == senderId);
            Chat chat = ServerStorage.Chats.Find((chat) => chat.Id == chatId);
            if (!chat.Users.Contains(sender))
            {
                throw new Exception("Вы взломщик, доступ запрещён!");
            }
            Message newMessage = new Message(textMessage, sender, DateTime.Now);
            chat.Messages.Add(newMessage);
            return newMessage;
        }
    }
}
