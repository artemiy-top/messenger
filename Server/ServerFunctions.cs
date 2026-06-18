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
        public static User? Register(string userName, string password)
        {
            User? alreadyUser = ServerStorage.Users.FirstOrDefault(user => user.Name == userName);
            if (alreadyUser != null)
            {
                return null;
            }
            User newUser = new User(userName, password);
            ServerStorage.Users.Add(newUser);
            return newUser;
        }

        public static string? Auth(string userName, string password)
        {
            User? authedUser = ServerStorage.Users.Find((user) => user.Name == userName && user.Password == password);
            if (authedUser != null)
            {
                authedUser.SessionId = Guid.NewGuid().ToString();
                return authedUser.SessionId;
            }
            return null;
        }

        public static Message SendMessage(string sessionId, string textMessage, int chatId)
        {
            User? sender = ServerStorage.Users.Find((user) => user.SessionId == sessionId);
            Chat? chat = ServerStorage.Chats.Find((chat) => chat.Id == chatId);

            if (chat == null)
            {
                throw new Exception("Нет такого чата!");
            }
            if (sender == null)
            {
                throw new Exception("Нет такого отправителя!");
            }
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
