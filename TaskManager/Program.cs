using TaskManager;

class Program
{
    static List<TaskItem> taska = new List<TaskItem>();
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Task Manager!");
        while (true)
        {
            ShowMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    Console.WriteLine("Exiting the Task Manager. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("1. Add Task");
        Console.WriteLine("2. View Tasks");
        Console.WriteLine("3. Complete Task");
        Console.WriteLine("4. Delete Task");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
    }

    static void AddTask()
    {
        Console.Write("Enter task title: ");
        string title = Console.ReadLine();
        Console.Write("Enter task description: ");
        string description = Console.ReadLine();
        int id = taska.Count + 1;
        TaskItem newTask = new TaskItem(id, title, description, false);
        taska.Add(newTask);
        Console.WriteLine("Task added successfully!");
    }
    static void ViewTasks()
    {
        if (taska.Count == 0)
        {
            Console.WriteLine("No tasks available.");
            return;
        }
        Console.WriteLine("\nCurrent Tasks:");
        foreach (var task in taska)
        {
            Console.WriteLine(task);
        }
    }
    static void CompleteTask()
    {
        Console.Write("Enter task ID to mark as completed: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var task = taska.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.MarkAsCompleted();
                Console.WriteLine("Task marked as completed.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID format.");
        }
    }
    static void DeleteTask()
    {
        Console.Write("Enter task ID to delete: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var task = taska.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                taska.Remove(task);
                Console.WriteLine("Task deleted successfully.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID format.");
        }
    }
}