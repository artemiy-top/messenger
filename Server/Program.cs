using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter();

var app = builder.Build();

app.UseWebSockets(new WebSocketOptions
{
    KeepAliveInterval = TimeSpan.FromMinutes(2)
});
app.MapCarter();

app.Run();