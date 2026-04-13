using AzureApiDemo.Models;

namespace AzureApiDemo.Services
{
    public class TaskService
    {
        private readonly List<TaskItem> _tasks = new();
        private int _nextId = 1;

        public IEnumerable<TaskItem> GetAll()
        {
            return _tasks;
        }

        public TaskItem Add(TaskItem task)
        {
            task.Id = _nextId++;
            _tasks.Add(task);
            return task;
        }
    }
}