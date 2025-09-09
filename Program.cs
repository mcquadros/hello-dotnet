var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// GET /ping - responds with "pong" string
app.MapGet("/ping", () => "pong");

// GET /hello - responds with JSON message
app.MapGet("/hello", () => new { message = "Hello from .NET Julia" });

app.Run();
