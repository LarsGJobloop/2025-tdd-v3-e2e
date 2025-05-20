var taskManager = new TaskManager.TaskManager();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/tasks", () =>
{
  return taskManager.Tasks;
});

app.MapPost("/tasks", (CreateTaskInfo createInfo) =>
{
  return taskManager.AddTask(createInfo.Title);
});

app.Run();
