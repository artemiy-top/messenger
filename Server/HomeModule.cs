using Microsoft.AspNetCore.Http;
using Server;
using Shared;
using System;
using System.Linq;

public class HomeModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app) {
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
            // TODO
        });

        app.MapPost("/get-chats", (HttpRequest request) =>
        {
            String sessionId = request.Headers.Authorization.ToString().Split("Bearer ")[1];
            User? user = ServerStorage.Users.First((user) => user.SessionId == sessionId);
            if (user == null)
            {
                throw new Exception("Access denied!");
            }
            Chat[] chats = ServerStorage
                .Chats
                .Where((chat) => chat.Users.Contains(user))
                .ToArray();

            ClientChat[] clientChats = chats
                .Select((chat) => new ClientChat
                {
                    Id = chat.Id,
                    LastMessage = "Последнее сообщение",
                    Title = chat.Users.First((u) => u.Id != user.Id)!.Name,
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
            // TODO
        });
    }
}
