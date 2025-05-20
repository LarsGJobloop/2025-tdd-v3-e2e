var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Testing testing");
app.MapGet("/tasks", () => "Returning all tasks");
app.MapPost("/tasks", () => "Creating a new task");

app.Run();
