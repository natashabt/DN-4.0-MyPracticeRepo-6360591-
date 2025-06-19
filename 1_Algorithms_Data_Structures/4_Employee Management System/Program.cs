using System;

class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string position, double salary)
    {
        EmployeeId = id;
        Name = name;
        Position = position;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"ID: {EmployeeId}, Name: {Name}, Position: {Position}, Salary: {Salary}";
    }
}

class EmployeeManager
{
    private Employee[] employees;
    private int count;

    public EmployeeManager(int size)
    {
        employees = new Employee[size];
        count = 0;
    }

    // Add an employee
    public void AddEmployee(Employee emp)
    {
        if (count < employees.Length)
        {
            employees[count] = emp;
            count++;
            Console.WriteLine("Employee added.");
        }
        else
        {
            Console.WriteLine("Employee array is full.");
        }
    }

    // Search by ID
    public Employee SearchEmployee(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
                return employees[i];
        }
        return null;
    }

    // Delete by ID
    public void DeleteEmployee(int id)
    {
        int index = -1;
        for (int i = 0; i < count; i++)
        {
            if (employees[i].EmployeeId == id)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("Employee not found.");
            return;
        }

        // Shift elements left
        for (int i = index; i < count - 1; i++)
        {
            employees[i] = employees[i + 1];
        }

        employees[count - 1] = null;
        count--;
        Console.WriteLine("Employee deleted.");
    }

    // Traverse / display all
    public void DisplayEmployees()
    {
        if (count == 0)
        {
            Console.WriteLine("No employees to display.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(employees[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeManager manager = new EmployeeManager(5);

        manager.AddEmployee(new Employee(1, "Alice", "Manager", 70000));
        manager.AddEmployee(new Employee(2, "Bob", "Developer", 60000));
        manager.AddEmployee(new Employee(3, "Charlie", "Tester", 50000));

        Console.WriteLine("\nAll Employees:");
        manager.DisplayEmployees();

        Console.WriteLine("\nSearching for Employee with ID 2:");
        var emp = manager.SearchEmployee(2);
        Console.WriteLine(emp != null ? emp.ToString() : "Not found");

        Console.WriteLine("\nDeleting Employee with ID 1:");
        manager.DeleteEmployee(1);

        Console.WriteLine("\nAll Employees After Deletion:");
        manager.DisplayEmployees();
    }
}
