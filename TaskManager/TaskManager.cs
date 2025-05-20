namespace TaskManager;

public class TaskManager
{
  public List<Task> Tasks = new List<Task>();

  public Task AddTask(string title)
  {
    var newTask = new Task();
    newTask.Title = title;
    newTask.Complete = false;
    newTask.CompletedAt = null;

    Tasks.Add(newTask);
    return newTask;
  }
}
