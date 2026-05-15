using Microsoft.AspNetCore.Http;
using System;

public class HomeModule : ICarterModule
{
    public class AuthRequest
    {
        public required string Name { get; set; }
        public required string Password { get; set; }
    }

    public class RegisterRequest
    {
        public required string Name { get; set; }
        public required string Password { get; set; }
    }

    public class SendMessageRequest
    {
        public required int ChatId { get; set; }
        public required string Message { get; set; }
    }

    public class GetLastMessageRequest
    {
        public required int ChatId { get; set; }
    }


    public void AddRoutes(IEndpointRouteBuilder app) {
        app.MapPost("/auth", (AuthRequest authRequest) =>
        {
            // TODO
        });

        app.MapPost("/register", (RegisterRequest registerRequest) =>
        {
            // TODO
        });

        app.MapPost("/get-last-messages", (HttpRequest request, GetLastMessageRequest getLastMessageRequest) =>
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
