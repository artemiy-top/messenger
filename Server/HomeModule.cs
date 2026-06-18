using Microsoft.AspNetCore.Http;
using Server;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class HomeModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app) {
        app.Map("/ws", async context => 
        {
            if (context.WebSockets.IsWebSocketRequest)
            {
                var webSocket = await context.WebSockets.AcceptWebSocketAsync();
                await webSocket.SendAsync(
                    Encoding.UTF8.GetBytes("example response"),
                    System.Net.WebSockets.WebSocketMessageType.Text,
                    true,
                    System.Threading.CancellationToken.None
                );

                byte[] bytes = new byte[1024];
                while (true)
                {
                    var data = await webSocket.ReceiveAsync(bytes, System.Threading.CancellationToken.None);
                    Console.WriteLine(Encoding.UTF8.GetString(bytes, 0, data.Count));
                }   
            }
            else
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        });

        app.MapGet("/users", () =>
        {
            List<ClientUser> clientUsers = ServerStorage.Users
                .Select(user => new ClientUser
                {
                    Id = user.Id,
                    Name = user.Name,
                })
                .ToList();

            return clientUsers;
        });

        app.MapPost("/add-friend", (HttpRequest request, AddFriendRequest addFriendRequest) =>
        {
            String sessionId = request.Headers.Authorization.ToString().Split("Bearer ")[1];
            User? user = ServerStorage.Users.First((user) => user.SessionId == sessionId);
            if (user == null)
            {
                throw new Exception("Access denied!");
            }

            User? newFriendUser = ServerStorage.Users.FirstOrDefault(user => user.Id == addFriendRequest.Id);
            if (newFriendUser == null)
            {
                throw new Exception("No that user!");
            }

            ServerStorage.Chats.Add(new Chat(user, newFriendUser));
            return true;
        });

        app.MapPost("/auth", (AuthRequest authRequest) =>
        {
            Console.WriteLine($"Попытка входа пользователя {authRequest.Name} с паролем {authRequest.Password}");

            string? sessionId = ServerFunctions.Auth(authRequest.Name, authRequest.Password);
            if (sessionId != null)
            {
                return sessionId;
            }
            else
            {
                return "";
            }
        });

        app.MapPost("/register", (RegisterRequest registerRequest) =>
        {
            User? user = ServerFunctions.Register(registerRequest.Name, registerRequest.Password);
            if (user == null)
            {
                return "";
            }

            string? sessionId = ServerFunctions.Auth(registerRequest.Name, registerRequest.Password);
            if (sessionId != null)
            {
                return sessionId;
            }
            else
            {
                return "";
            }
        });

        app.MapGet("/get-chat/{chatId}", (HttpRequest request, int chatId) =>
        {
            String sessionId = request.Headers.Authorization.ToString().Split("Bearer ")[1];
            User? user = ServerStorage.Users.FirstOrDefault((user) => user.SessionId == sessionId);
            if (user == null)
            {
                throw new Exception("Access denied!");
            }

            Chat? chat = ServerStorage.Chats.FirstOrDefault((chat) => chat.Id == chatId);
            if (chat == null)
            {
                throw new Exception("Такого чата нет!");
            }

            ClientMessage[] clientMessages = chat
                .Messages
                .Select((message) => new ClientMessage
                {
                    Text = message.Text,
                    SenderId = message.Sender.Id,
                    SenderName = message.Sender.Name,
                    DateTime = message.DateTime
                })
                .ToArray();

            return clientMessages;
        });
        
        app.MapGet("/get-chats", (HttpRequest request) =>
        {
            String sessionId = request.Headers.Authorization.ToString().Split("Bearer ")[1];
            User? user = ServerStorage.Users.First((user) => user.SessionId == sessionId);
            if (user == null)
            {
                throw new Exception("Access denied!");
            }

            Chat[] chats = ServerStorage.Chats.Where((chat) => chat.Users.Contains(user)).ToArray();
            ClientChat[] clientChats = chats
                .Select((chat) => new ClientChat
                {
                    Id = chat.Id,
                    LastMessage = "Последнее сообщение",
                    Title = chat.Users.First((anotherUser) => anotherUser.Id != user.Id).Name,
                })
                .ToArray();

            return clientChats;
        });

        app.MapPost("/get-last-messages", (HttpRequest request, GetLastMessagesRequest getLastMessageRequest) =>
        {
            String sessionId = request.Headers.Authorization.ToString().Split("Bearer ")[1];
            // TODO
        });

        app.MapPost("/send-message", (HttpRequest request, SendMessageRequest messageRequest) =>
        {
            String sessionId = request.Headers.Authorization.ToString().Split("Bearer ")[1];
            User? user = ServerStorage.Users.First((user) => user.SessionId == sessionId);
            if (user == null)
            {
                throw new Exception("Access denied!");
            }

            Chat? chat = ServerStorage.Chats.First((chat) => chat.Id == messageRequest.ChatId);
            if (chat == null)
            {
                throw new Exception("Нет такого чата");
            }

            chat.Messages.Add(new Message(messageRequest.Message, user, DateTime.Now));
            return true;
        });
    }
}
