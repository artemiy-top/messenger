using Microsoft.AspNetCore.Http;
using Server;
using Shared;
using System;

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
