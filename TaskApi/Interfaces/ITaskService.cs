using TaskApi.Models;

namespace TaskApi.Interfaces
{
    public interface ITaskService
    {
        List<TaskItem> GetAll();
        TaskItem GetById(int id);
        TaskItem Create(string title);
        bool Update(int id, string title, bool isCompleted);
        bool Delete(int id);
    }
}
