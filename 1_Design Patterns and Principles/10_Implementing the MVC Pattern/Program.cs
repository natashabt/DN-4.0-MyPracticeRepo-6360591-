using System;

// 1. Model Class
public class Student
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Grade { get; set; }

    public Student(string name, int id, string grade)
    {
        Name = name;
        Id = id;
        Grade = grade;
    }
}

// 2. View Class
public class StudentView
{
    public void DisplayStudentDetails(Student student)
    {
        Console.WriteLine("=== Student Details ===");
        Console.WriteLine($"ID    : {student.Id}");
        Console.WriteLine($"Name  : {student.Name}");
        Console.WriteLine($"Grade : {student.Grade}");
        Console.WriteLine();
    }
}

// 3. Controller Class
public class StudentController
{
    private Student student;
    private StudentView view;

    public StudentController(Student student, StudentView view)
    {
        this.student = student;
        this.view = view;
    }

    public void UpdateView()
    {
        view.DisplayStudentDetails(student);
    }

    public void SetStudentName(string name)
    {
        student.Name = name;
    }

    public void SetStudentGrade(string grade)
    {
        student.Grade = grade;
    }

    public string GetStudentName()
    {
        return student.Name;
    }

    public string GetStudentGrade()
    {
        return student.Grade;
    }
}

// 4. Main (Test Class)
class Program
{
    static void Main(string[] args)
    {
        // Create Model
        Student student = new Student("Alice", 101, "A");

        // Create View
        StudentView view = new StudentView();

        // Create Controller
        StudentController controller = new StudentController(student, view);

        // Display original details
        controller.UpdateView();

        // Update model data
        controller.SetStudentName("Bob");
        controller.SetStudentGrade("B+");

        // Display updated details
        controller.UpdateView();
    }
}
