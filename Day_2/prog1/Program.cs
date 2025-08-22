using System;

class Student
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    // Constructor
    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input Handling
        Console.WriteLine("Enter student's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter student's age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student's grade:");
        string grade = Console.ReadLine();

        // Create instance
        Student student = new Student(name, age, grade);

        // Output
        Console.WriteLine("Student Name: " + student.Name);
        Console.WriteLine("Student Age: " + student.Age);
        Console.WriteLine("Student Grade: " + student.Grade);
    }
}
