using System;

class Task
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public string Status { get; set; }
    public Task Next { get; set; }

    public Task(int id, string name, string status)
    {
        TaskId = id;
        TaskName = name;
        Status = status;
        Next = null;
    }

    public override string ToString()
    {
        return $"TaskId: {TaskId}, TaskName: {TaskName}, Status: {Status}";
    }
}

class TaskManager
{
    private Task head;

    // Add task at end
    public void AddTask(int id, string name, string status)
    {
        Task newTask = new Task(id, name, status);

        if (head == null)
        {
            head = newTask;
        }
        else
        {
            Task current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newTask;
        }

        Console.WriteLine("Task added.");
    }

    // Search task by ID
    public Task SearchTask(int id)
    {
        Task current = head;
        while (current != null)
        {
            if (current.TaskId == id)
                return current;
            current = current.Next;
        }
        return null;
    }

    // Delete task by ID
    public void DeleteTask(int id)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.TaskId == id)
        {
            head = head.Next;
            Console.WriteLine("Task deleted.");
            return;
        }

        Task prev = null;
        Task current = head;

        while (current != null && current.TaskId != id)
        {
            prev = current;
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Task not found.");
            return;
        }

        prev.Next = current.Next;
        Console.WriteLine("Task deleted.");
    }

    // Traverse and display all tasks
    public void DisplayTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks to display.");
            return;
        }

        Task current = head;
        while (current != null)
        {
            Console.WriteLine(current);
            current = current.Next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TaskManager manager = new TaskManager();

        manager.AddTask(1, "Design database", "Pending");
        manager.AddTask(2, "Write API", "In Progress");
        manager.AddTask(3, "Test login", "Completed");

        Console.WriteLine("\nAll Tasks:");
        manager.DisplayTasks();

        Console.WriteLine("\nSearching for Task ID 2:");
        var task = manager.SearchTask(2);
        Console.WriteLine(task != null ? task.ToString() : "Task not found");

        Console.WriteLine("\nDeleting Task ID 1:");
        manager.DeleteTask(1);

        Console.WriteLine("\nAll Tasks After Deletion:");
        manager.DisplayTasks();
    }
}
