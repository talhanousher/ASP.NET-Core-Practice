using TaskApi.Interfaces;
using TaskApi.Models;

namespace TaskApi.Services
{
    public class TaskService: ITaskService
    {
        private readonly List<TaskItem> _tasks = new();
        private int _nextId = 1;

        public List<TaskItem> GetAll() => _tasks;

        public TaskItem GetById(int id) => _tasks.FirstOrDefault(t => t.Id == id);

        public TaskItem Create(string title)
        {
            var task = new TaskItem { Id = _nextId++, Title = title, IsCompleted = false };
            _tasks.Add(task);
            return task;
        }

        public bool Update(int id, string title, bool isCompleted)
        {
            var task = GetById(id);
            if (task == null) return false;

            task.Title = title;
            task.IsCompleted = isCompleted;
            return true;
        }

        public bool Delete(int id)
        {
            var task = GetById(id);
            if (task == null) return false;
            return _tasks.Remove(task);
        }
    }
}
