var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// GET /ping - responds with "pong" string
app.MapGet("/ping", () => "pong");

// GET /hello - responds with JSON message
app.MapGet("/hello", () => new { message = "Hello from .NET!" });

app.Run();
